﻿using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.SetPassword;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.MainMenu
{
    public class MainMenu : Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {

            string text = messageInfo.Message.Text;
            switch (text)
            {
                case "Изменить пароль":
                {
                        //await InitMessage(messageInfo, client);

                        Chat.CurrentMessage = new PasswordInvitation(ContextFactory, DbQueries)
                        {
                            Chat = new Chat(new PasswordInvitation(ContextFactory, DbQueries))
                        };
                        await Chat.CurrentMessage.InitMessage(messageInfo, client);
                    break;
                }
                default:
                {
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Ошибка");
                    break;
                }
            }
        }
        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
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

        }

        public MainMenu(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries) : base(contextFactory, dbQueries)
        {
        }
    }
}