using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace Croc.Medkiosk.TelegramBot.Messaging
{
    public abstract class Message : IMessage
    {
        public Chat Chat { get; set; }

        protected readonly IDbContextFactory<newmed2_dockerContext> ContextFactory;

        protected readonly DbQueries DbQueries;

        protected Message(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries)
        {
            this.ContextFactory = contextFactory;
            this.DbQueries = dbQueries;
        }

        public abstract Task HandleUserRequest(Update messageInfo, TelegramBotClient client);
    }
}