using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using System;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using Telegram.Bot.Types.ReplyMarkups;
using FirstApp.Models;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FirstApp
{
    class Program
    {
        private static TelegramBotClient client;
        private static string token { get; set; } =  "secret";
        private static string server_conn { get; set; } = "secret";
        
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += BotOnMessageReceived;
            //client.OnMessageEdited += BotOnMessageReceived;
            Console.ReadLine();
            client.StopReceiving();
            await host.RunAsync();

        }

        private static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            if (message.Text != null)
            {
                string text = message.Text;

                switch (text)
                {
                    case "/start":
                        Bot_OnMessage(messageEventArgs);
                        break;
                    default:
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, "Error");
                        break;
                    }
                }
            }

            if (message.Contact != null)
            {
                if (message.Contact.UserId == message.From.Id)
                {
                    bool check_phone = false;
                    using (var db = new newmed2_dockerContext())
                    {

                        var authenticators = db.Authenticities.ToList();
                        var phoneAuthenticator = db.Authenticitytypes.FirstOrDefault(p => p.Name == "PhoneNumber");
                        foreach (var authenticator in authenticators)
                        {

                            if (authenticator.Type == phoneAuthenticator.Objectid && authenticator.Value != null)
                            {
                                
                                var numberFromDb = string.Join("", authenticator.Value.Where(char.IsDigit).Skip(1));
                                var numberFromTg = string.Join("", message.Contact.PhoneNumber.Where(char.IsDigit).Skip(1));
                                if (numberFromDb != numberFromTg)
                                {
                                    check_phone = true;
                                    var check_exist = db.Telegramidentities.FirstOrDefault(p => p.Telegramid == message.Chat.Id.ToString());
                                    if (check_exist == null)
                                    {
                                        var telegramidentity = new Telegramidentity { };
                                        telegramidentity.Objectid = Guid.NewGuid();
                                        telegramidentity.Telegramid = message.Chat.Id.ToString();
                                        telegramidentity.Authenticity = authenticator.Objectid;
                                        db.Telegramidentities.Add(telegramidentity);
                                        db.SaveChanges();
                                    }
                                    break;

                                }

                            }

                        }

                    }

                    if (check_phone)
                    {
                        MainMenu(messageEventArgs);

                    }
                    else
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, "Пользователь с таким номером не найден. Обратитесь к администратору");
                    }
                }
                else
                {

                    Bot_OnMessage(messageEventArgs);
                    
                }
            }


        }

        private static async void Bot_OnMessage(MessageEventArgs e)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");

            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);

            await client.SendTextMessageAsync(e.Message.Chat, "Please send contact", replyMarkup: keyboard);
        }

        private static async void MainMenu(MessageEventArgs e)
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Изменить пароль"),
                    
                }
            };
            await client.SendTextMessageAsync(e.Message.Chat.Id, "Вы в главном меню", replyMarkup: rkm);

        }


        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, configuration) =>
                {
                    //configuration.Sources.Clear();

                    IHostEnvironment env = hostingContext.HostingEnvironment;
                    string dir = @"C:\test";
                    configuration
                        .AddJsonFile($"{Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"))}appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"{Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"))}appsettings.Development.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
                    IConfigurationRoot configurationRoot = configuration.Build();

                    TransientFaultHandlingOptions options = new TransientFaultHandlingOptions();
                    configurationRoot.GetSection(nameof(TransientFaultHandlingOptions))
                                     .Bind(options);
                    token = configurationRoot["Token"];
                    server_conn = configurationRoot["ServerCon"];
                    });
    }

    public class TransientFaultHandlingOptions
    {
        public bool Enabled { get; set; }
        public TimeSpan AutoRetryDelay { get; set; }
    }

}
