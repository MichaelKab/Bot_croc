using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating
{
    public class Authorization : Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
            bool checkPhone = false;

            if (messageInfo.Message.Contact != null)
            {
                if (messageInfo.Message.From.Id == messageInfo.Message.Contact.UserId)
                {
                    using (var db = ContextFactory.CreateDbContext())
                    {
                        var numberFromTg = string.Join("",
                           messageInfo.Message.Contact.PhoneNumber.Where(char.IsDigit).Skip(1));
                        //const string pattern = @"^(?:\+|\d|\()[\d\-\(\) .]{8,16}\d+$";
                        //[900]{ 3}\D *[111]{ 3}\D *[22]{ 2}\D *[33]{ 2}$
                        //var numberFromTg = "0000000001";
                        
                        string pattern = @$"{numberFromTg.Substring(0, 3)}" +@"\D*" + @$"{numberFromTg.Substring(3, 3)}" + @"\D*" + @$"{numberFromTg.Substring(6, 2)}" + @"\D*" + @$"{numberFromTg.Substring(8, 2)}" + @"$";
                        var authenticators = await db.Authenticities.Where(b => Regex.IsMatch(b.Value, pattern))
                            .ToListAsync();
                        if (authenticators.Count > 1)
                        {
                            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id,
                                "для прохождения регистрации сообщите администратору");
                            Log.Error($"duplicate number: {numberFromTg}");
                        }
                        else
                        {

                            var authenticator = authenticators.FirstOrDefault();
                            if (authenticator == null)
                            { 
                                checkPhone = true;
                                var checkExist = await db.Telegramidentities.FirstOrDefaultAsync(p =>
                                    p.Telegramid == messageInfo.Message.Chat.Id.ToString());
                                if (checkExist == null)
                                {
                                    var telegramidentity = new Telegramidentity { };
                                    telegramidentity.Objectid = Guid.NewGuid();
                                    telegramidentity.Telegramid = messageInfo.Message.Chat.Id.ToString();
                                    telegramidentity.Authenticity = authenticator.Objectid;
                                    await db.Telegramidentities.AddAsync(telegramidentity);
                                    await db.SaveChangesAsync();
                                }
                            }
                        }
                    }
                }

                if (checkPhone)
                {
                    await Transition(messageInfo, client);
                    
                }
                else
                { 
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, 
                        "Пользователь с таким номером не найден. Обратитесь к администратору");
                }
            }
        
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Некорректные данные");
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
            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Вы в главном меню",
                replyMarkup: rkm);
            Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory);
            Chat.CurrentMessage.Chat = new Chat(new MainMenu.MainMenu(ContextFactory));
        }


        public Authorization(IDbContextFactory<newmed2_dockerContext> contextFactory) : base(contextFactory)
        {
        }
    }
}
