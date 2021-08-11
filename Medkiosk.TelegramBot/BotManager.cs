using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using Serilog;

namespace Croc.Medkiosk.TelegramBot
{
    public class BotManager : BackgroundService
    {
        private readonly TelegramBotClient _client;

        private readonly BotConfig _config;
        private readonly IDbContextFactory<newmed2_dockerContext> _contextFactory;
        private readonly ILogger<BotManager> _logger;

        public BotManager(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            IOptions<BotConfig> configOptions,
            ILogger<BotManager> logger)
        {
            _config = configOptions.Value;
            _contextFactory = contextFactory;
            _logger = logger;

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
            _logger.LogDebug($"Message: {message.Text}");
            if (message.Text != null)
            {
                string text = message.Text;
                using (var db = _contextFactory.CreateDbContext())
                {
                    var checkExist =
                        await db.Telegramidentities.FirstOrDefaultAsync(p =>
                            p.Telegramid == message.Chat.Id.ToString());
                if (checkExist != null)
                {
                    switch (text)
                    {
                        case "Изменить пароль":
                        {
                            await _client.SendTextMessageAsync(message.Chat.Id, "Отправьте пароль");
                            break;
                        }
                        default:
                        {
                            if (text.Length >= 8 && Regex.IsMatch(text, @"[A-Z]") == Regex.IsMatch(text, @"\d") ==
                                Regex.IsMatch(text, @"[a-z]") == true)
                            {
                                using (SHA256 mySHA256 = SHA256.Create())
                                {
                                    byte[] bytes = Encoding.ASCII.GetBytes(text);
                                    var hash = new System.Text.StringBuilder();
                                    byte[] hashValue = mySHA256.ComputeHash(bytes);
                                    foreach (byte theByte in hashValue)
                                    {
                                        hash.Append(theByte.ToString("x2"));
                                    }

                                    var passwList = await db.Passwords.Where(p =>
                                        p.Authenticity == checkExist.Authenticity).ToListAsync();
                                    if (passwList.Count > 1)
                                    {
                                        _logger.LogError($"User {checkExist.Authenticity} has a lot of passwords");
                                    }

                                    var passw = passwList.FirstOrDefault();
                                    if (passw != null)
                                    {
                                        passw.Flags = 1;
                                        passw.Value = hash.ToString();
                                    }
                                    else
                                    {
                                        var password = new Password { };
                                        password.Authenticity = checkExist.Authenticity;
                                        password.Flags = 1;
                                        password.Value = hash.ToString();
                                        await db.Passwords.AddAsync(password);
                                    }

                                    await db.SaveChangesAsync();
                                    await _client.SendTextMessageAsync(message.Chat.Id, "Пароль сохранён");
                                    await MainMenu(messageEventArgs);
                                }
                            }
                            else
                            {
                                await _client.SendTextMessageAsync(message.Chat.Id, "Пароль не подходит по требованиям");
                            }



                            break;
                        }
                    }
                }
                else
                {
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
                }

                
            }

            if (message.Contact == null) return;

            if (message.Contact.UserId == message.From.Id)
            {
                bool checkPhone = false;

                await using (var db = _contextFactory.CreateDbContext())
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
                    await MainMenu(messageEventArgs);

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

        private async Task MainMenu(MessageEventArgs e)
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