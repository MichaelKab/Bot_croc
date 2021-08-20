using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.SetPassword
{
    public class PasswordInvitation : Message
    {
        //public override async Task HandleUserRequest(Update messageInfo)
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
            var text = messageInfo.Message.Text;

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

                    using (var db = ContextFactory.CreateDbContext())
                    {
                        var checkExist =
                            await db.Telegramidentities.FirstOrDefaultAsync(p =>
                                p.Telegramid == messageInfo.Message.Chat.Id.ToString());
                        var passwList = await db.Passwords.Where(p =>
                            p.Authenticity == checkExist.Authenticity).ToListAsync();
                        if (passwList.Count > 1)
                        {
                            Log.Error($"User {checkExist.Authenticity} has a lot of passwords");
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
                        await Transition( messageInfo, client);


                    }
                }
            }
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Пароль не подходит по требованиям");
            }



        }
        public override async Task Transition(Update messageInfo, TelegramBotClient client)
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Изменить пароль"),

                }
            };
            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Пароль сохранён");
            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Вы в главном меню",
                replyMarkup: rkm);
            Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory);
            Chat.CurrentMessage.Chat = new Chat(new MainMenu.MainMenu(ContextFactory));
        }
        public PasswordInvitation(IDbContextFactory<newmed2_dockerContext> contextFactory) : base(contextFactory)
        {
        }
    }
}