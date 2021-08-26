using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Extensions.Polling;
using Chat = Croc.Medkiosk.TelegramBot.Messaging.Chat;

namespace Croc.Medkiosk.TelegramBot
{
    public class BotManager : BackgroundService
    {
        private readonly TelegramBotClient _client;
        
        private readonly BotConfig _config;
        private readonly IDbContextFactory<newmed2_dockerContext> _contextFactory;
        private readonly DbQueries _dbQueries;

        private readonly Dictionary<string, Chat> chatDictionary = new Dictionary<string, Chat>();
        private readonly ILogger<BotManager> _logger;

        public BotManager(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            DbQueries dbQueries,
            IOptions<BotConfig> configOptions,
            ILogger<BotManager> logger)
        {
            _config = configOptions.Value;
            _contextFactory = contextFactory;
            _dbQueries = dbQueries;
            _logger = logger;

            _client = new TelegramBotClient(_config.Token);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //HandleErrorAsync(_clientClient);
            QueuedUpdateReceiver updateReceiver = new QueuedUpdateReceiver(_client);

            updateReceiver.StartReceiving(cancellationToken: stoppingToken);

            await foreach (Update update in updateReceiver.YieldUpdatesAsync())
            {
                if (update.Message is Message message)
                {
                    //await HandleUpdateAsync(update, stoppingToken);
                    await BotOnMessageReceived(update, stoppingToken);
                }
            }
        }


        private async Task BotOnMessageReceived(Update update, CancellationToken cancellationToken)
        {
            _logger.LogDebug($"Получено сообщение: {update.Message.Text}");

            try
            {
                if (chatDictionary.ContainsKey(update.Message.Chat.Id.ToString()))
                {
                    var chat = chatDictionary[update.Message.Chat.Id.ToString()];
                    if (update.Message.Text != "Отменить")
                    {
                        await chat.HandleUserRequest(update, _client);
                        chatDictionary[update.Message.Chat.Id.ToString()] = chat.CurrentMessage.Chat;
                    }
                    else
                    {
                        chat.CurrentMessage = new Messaging.Conversation.MainMenu.MainMenu(_contextFactory, _dbQueries)
                        {
                            Chat = chat
                        };
                        await chat.CurrentMessage.InitMessage(update, _client);
                    }

                }
                else
                {
                    var el = new Chat(new StartMessage(_contextFactory, _dbQueries));
                    await el.HandleUserRequest(update, _client);
                    chatDictionary.Add(update.Message.Chat.Id.ToString(), el);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "При обработке сообщения {0} от пользователя {1} произошла ошибка", 
                    update.Message.Text,
                    update.Message.Chat.Id);
                await _client.SendTextMessageAsync(update.Message.Chat.Id,
                    "При обработке сообщения произошла неизвестная ошибка. Обратитесь к администратору.");
            }
        }

    }

    
}