using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Croc.Medkiosk.TelegramBot.Messaging
{
    public class Chat
    {
        public IMessage CurrentMessage { get; set; }
        public IDbContextFactory<newmed2_dockerContext> ContextFactory { get; set; }

        public Chat(IMessage initialMessage)
        {
            CurrentMessage = initialMessage;
            CurrentMessage.Chat = this;
        }

        //public async Task HandleUserRequest(Update messageInfo)
        public async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
             await CurrentMessage.HandleUserRequest(messageInfo, client);
        }

        private async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            await CurrentMessage.InitMessage(messageInfo, client);
        }
    }
}