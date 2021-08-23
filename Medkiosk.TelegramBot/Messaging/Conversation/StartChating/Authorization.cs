using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Medkiosk.TelegramBot.Core.Exceptions;
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
            if (messageInfo.Message.Contact != null)
            {
                if (messageInfo.Message.From.Id == messageInfo.Message.Contact.UserId)
                {
                    var checkPhone = false;
                    try
                    {
                        await DbQueries.RegisterTelegramId(
                            messageInfo.Message.Contact.PhoneNumber,
                            messageInfo.Message.Chat.Id.ToString());
                        Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries);
                        Chat.CurrentMessage.Chat = new Chat(new MainMenu.MainMenu(ContextFactory, DbQueries));
                        await Chat.CurrentMessage.InitMessage(messageInfo, client);
                        /*var numberFromTg = string.Join("",
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
                        await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, e.Message);
                        */
                    }
                    
                    catch (BotBusinessLogicException e)
                    {
                        await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, e.Message);
                    }
                }
                else
                {
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Некорректные данные");
                }
            }
            
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Некорректные данные");
            }
        }

        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");
            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);
            await client.SendTextMessageAsync(messageInfo.Message.Chat, "Please send contact", replyMarkup: keyboard);
        }


        public Authorization(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            DbQueries dbQueries) 
            : base(contextFactory, dbQueries) { }
    }
}
