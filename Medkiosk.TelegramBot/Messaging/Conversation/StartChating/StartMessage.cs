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
            if (DbQueries.CheckRegisteredTelegramId(messageInfo.Message.Chat.Id.ToString()))
            {
                Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries)
                {
                    Chat = new Chat(new MainMenu.MainMenu(ContextFactory, DbQueries))
                };
            }
            else
            {
                Chat.CurrentMessage = new Authorization(ContextFactory, DbQueries)
                {
                    Chat = new Chat(new Authorization(ContextFactory, DbQueries))
                };
            }
            await Chat.CurrentMessage.InitMessage(messageInfo, client);
        }
        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            
        }

        public StartMessage(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries) : base(contextFactory, dbQueries)
        {
        }
    }
}
