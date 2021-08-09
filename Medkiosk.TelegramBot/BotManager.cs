using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _client.StartReceiving();
            _client.OnMessage += BotOnMessageReceived;
            //client.OnMessageEdited += BotOnMessageReceived;
        }

        public override void Dispose()
        {
            _client.StopReceiving();
            base.Dispose();
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            if (message.Text != null)
            {
                string text = message.Text;

                switch (text)
                {
                    case "/start":
                        await Bot_OnMessage(messageEventArgs);
                        break;
                    default:
                        {
                            await _client.SendTextMessageAsync(message.Chat.Id, "Error");
                            break;
                        }
                }
            }

            if (message.Contact == null) return;

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
                                db.Telegramidentities.Add(telegramidentity);
                                await db.SaveChangesAsync();
                            }
                            break;
                        }

                    }

                }

                if (checkPhone)
                {
                    MainMenu(messageEventArgs);

                }
                else
                {
                    await _client.SendTextMessageAsync(message.Chat.Id, "Пользователь с таким номером не найден. Обратитесь к администратору");
                }
            }
            else
            {

                await Bot_OnMessage(messageEventArgs);

            }


        }

        private async Task Bot_OnMessage(MessageEventArgs e)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");

            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);

            await _client.SendTextMessageAsync(e.Message.Chat, "Please send contact", replyMarkup: keyboard);
        }

        private async void MainMenu(MessageEventArgs e)
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Изменить пароль"),

                }
            };
            await _client.SendTextMessageAsync(e.Message.Chat.Id, "Вы в главном меню", replyMarkup: rkm);

        }
    }
}