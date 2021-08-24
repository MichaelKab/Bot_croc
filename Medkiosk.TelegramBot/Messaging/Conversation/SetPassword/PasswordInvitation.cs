using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Medkiosk.TelegramBot.Core.Exceptions;
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
                    StringBuilder hash = new System.Text.StringBuilder();
                    byte[] hashValue = mySHA256.ComputeHash(bytes);
                    foreach (byte theByte in hashValue)
                    {
                        hash.Append(theByte.ToString("x2"));
                    }
                    
                    await DbQueries.EditPassword(
                        hash.ToString(),
                        messageInfo.Message.Chat.Id.ToString());
                    await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Пароль сохранён");
                    Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries)
                    {
                        Chat = new Chat(new MainMenu.MainMenu(ContextFactory, DbQueries))
                    };
                    await Chat.CurrentMessage.InitMessage(messageInfo, client);

                    
                }
            }
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Пароль не подходит по требованиям");
            }



        }

        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            // var nButton = new ReplyKeyboardRemove();
            var button = AddCancellableMessage();
            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Отправьте пароль", replyMarkup: button);
        }

        public PasswordInvitation(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries) : base(
            contextFactory, dbQueries)
        {
        }
    }
}
