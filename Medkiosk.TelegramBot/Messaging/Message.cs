using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

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
        public abstract Task InitMessage(Update messageInfo, TelegramBotClient client);

        public ReplyKeyboardMarkup AddCancellableMessage()
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Отменить"),

                }
            };
            return rkm;
        }
    }

    public abstract class CancellableMessage : Message
    {
        
        public CancellableMessage(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            DbQueries dbQueries)
            : base(contextFactory, dbQueries) { }

        public ReplyKeyboardMarkup AddCancellableMessage()
        {
            var rkm = new ReplyKeyboardMarkup();
            rkm.Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Отменить"),

                }
            };
            return rkm;
        }


    }
}