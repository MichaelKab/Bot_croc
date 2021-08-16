using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.SetPassword;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
//using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using Telegram.Bot.Exceptions;
//using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;

//using Telegram.Bot.Exceptions.Polling;
using Telegram.Bot.Extensions.Polling;
using Chat = Croc.Medkiosk.TelegramBot.Messaging.Chat;

namespace Croc.Medkiosk.TelegramBot
{
    public class BotManager : BackgroundService
    {
        private readonly TelegramBotClient _client;
        
        private readonly BotConfig _config;
        private readonly IDbContextFactory<newmed2_dockerContext> _contextFactory;

        public BotManager(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            IOptions<BotConfig> configOptions)
        {
            _config = configOptions.Value;
            _contextFactory = contextFactory;

            _client = new TelegramBotClient(_config.Token);
        }

        async Task HandleErrorAsync(Exception exception, CancellationToken cancellationToken)
        {
            if (exception is ApiRequestException apiRequestException)
            {
                await _client.SendTextMessageAsync(123, apiRequestException.ToString());
            }
        }

        private async Task Bot_OnMessage_2(Update update, CancellationToken cancellationToken)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");

            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);

            await _client.SendTextMessageAsync(update.Message.Chat, "Please send contact", replyMarkup: keyboard);
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string basedir = AppDomain.CurrentDomain.BaseDirectory;
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.RollingFile(basedir + "/Logs/log-{Date}.txt")

                .CreateLogger();

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

        private readonly Dictionary<string, Chat> chatDictionary = new Dictionary<string, Chat>(); 
        private async Task BotOnMessageReceived(Update update, CancellationToken cancellationToken)
        {
            if (chatDictionary.ContainsKey(update.Message.Chat.Id.ToString()))
            {
                var status = chatDictionary[update.Message.Chat.Id.ToString()];
                await status.HandleUserRequest(update, _client);
                chatDictionary[update.Message.Chat.Id.ToString()] = status.CurrentMessage.Chat;
                
            }
            else
            {
                var el = new Chat(new StartMessage(_contextFactory));
                await el.HandleUserRequest(update, _client);
                chatDictionary.Add(update.Message.Chat.Id.ToString(), el);
            }
            var message = update.Message;
            Log.Debug($"Message: {message.Text}");
            
        }

        private async Task Bot_OnMessage(MessageEventArgs e)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");

            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);

            await _client.SendTextMessageAsync(e.Message.Chat, "Please send contact", replyMarkup: keyboard);
        }

        private async Task MainMenu(Update update, CancellationToken cancellationToken)
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Изменить пароль"),

                }
            };
            await _client.SendTextMessageAsync(update.Message.Chat.Id, "Вы в главном меню", replyMarkup: rkm);

        }


        public async Task ResponseStartMenu(Message message)
        {
            if (message.Contact.UserId == message.From.Id)
            {
                bool checkPhone = false;

                using (var db = _contextFactory.CreateDbContext())
                {
                    const string pattern = @"^(?:\+|\d|\()[\d\-\(\) .]{8,16}\d+$";
                    var authenticators = await db.Authenticities.Where(b => Regex.IsMatch(b.Value, pattern)).ToListAsync();
                    foreach (var authenticator in authenticators)
                    {
                        var numberFromDb = string.Join("", authenticator.Value.Where(char.IsDigit).Skip(1));
                        var numberFromTg = string.Join("", message.Contact.PhoneNumber.Where(char.IsDigit).Skip(1));
                        if (numberFromDb == numberFromTg)
                        {
                            checkPhone = true;
                            var checkExist = await db.Telegramidentities.FirstOrDefaultAsync(p => p.Telegramid == message.Chat.Id.ToString());
                            if (checkExist == null)
                            {
                                var telegramidentity = new Telegramidentity { };
                                telegramidentity.Objectid = Guid.NewGuid();
                                telegramidentity.Telegramid = message.Chat.Id.ToString();
                                telegramidentity.Authenticity = authenticator.Objectid;
                                await db.Telegramidentities.AddAsync(telegramidentity);
                                await db.SaveChangesAsync();
                            }
                            break;
                        }

                    }

                }

                if (checkPhone)
                {
                    

                }
                else
                {
                    await _client.SendTextMessageAsync(message.Chat.Id, "Пользователь с таким номером не найден. Обратитесь к администратору");
                }
            }
            else
            {

                await _client.SendTextMessageAsync(message.Chat.Id, "Пользователь с таким номером не найден. Обратитесь к администратору");

            }
        }
        public void ResponseMainMenu(Message message)
        {

        }
    }

    
}