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
                    try
                    {
                        await DbQueries.RegisterTelegramId(
                            messageInfo.Message.Contact.PhoneNumber,
                            messageInfo.Message.Chat.Id.ToString());
                    }
                    catch (BotBusinessLogicException e)
                    {
                        await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, e.Message);
                    }
                }

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
                Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries);
                Chat.CurrentMessage.Chat = new Chat(new MainMenu.MainMenu(ContextFactory, DbQueries));
            }
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Некорректные данные");
            }

        }


        public Authorization(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            DbQueries dbQueries) 
            : base(contextFactory, dbQueries) { }
    }
}
