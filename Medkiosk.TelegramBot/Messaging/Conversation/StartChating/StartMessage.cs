using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating
{
    public class StartMessage: Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Send contact");
            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button); 
            await client.SendTextMessageAsync(messageInfo.Message.Chat, "Please send contact", replyMarkup: keyboard);
            Chat.CurrentMessage = new Authorization(ContextFactory, DbQueries);
            Chat.CurrentMessage.Chat = new Chat(new Authorization(ContextFactory, DbQueries));
        }

        public StartMessage(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries) : base(contextFactory, dbQueries)
        {
        }
    }
}
