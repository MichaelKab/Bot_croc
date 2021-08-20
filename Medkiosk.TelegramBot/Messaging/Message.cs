using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace Croc.Medkiosk.TelegramBot.Messaging
{
    public abstract class Message : IMessage
    {
        public Chat Chat { get; set; }
        //public Update MessageInfo { get; set; }
        //public abstract Task HandleUserRequest();
        protected IDbContextFactory<newmed2_dockerContext> ContextFactory { get; set; }

        public Message(IDbContextFactory<newmed2_dockerContext> contextFactory)
        {
            this.ContextFactory = contextFactory;
        }
        public abstract Task HandleUserRequest(Update messageInfo, TelegramBotClient client);
        public abstract Task InitMessage(Update messageInfo, TelegramBotClient client);
    }
}