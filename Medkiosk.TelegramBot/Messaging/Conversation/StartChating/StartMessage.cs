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
            await Transition(messageInfo, client);
        }
        public override async Task Transition(Update messageInfo, TelegramBotClient client)
        {
            Chat.CurrentMessage = new Authorization(ContextFactory);
            Chat.CurrentMessage.Chat = new Chat(new Authorization(ContextFactory));
        }

        public StartMessage(IDbContextFactory<newmed2_dockerContext> contextFactory) : base(contextFactory)
        {
        }
    }
}
