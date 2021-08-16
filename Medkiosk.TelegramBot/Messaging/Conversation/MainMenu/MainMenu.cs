using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.SetPassword;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
                    var no_button = new ReplyKeyboardRemove();
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Отправьте пароль", replyMarkup: no_button);
                    Chat.CurrentMessage = new PasswordInvitation(ContextFactory);
                    Chat.CurrentMessage.Chat = new Chat(new PasswordInvitation(ContextFactory));
                        break;
                }
                default:
                {
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Ошибка");
                    break;
                }
            }
        }

        public MainMenu(IDbContextFactory<newmed2_dockerContext> contextFactory) : base(contextFactory)
        {
        }
    }
}