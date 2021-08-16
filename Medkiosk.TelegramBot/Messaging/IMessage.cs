using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace Croc.Medkiosk.TelegramBot.Messaging
{
    public interface IMessage
    {
        //Update MessageInfo { get; set; }

        //Task HandleUserRequest(Update messageInfo);
        //public IDbContextFactory<newmed2_dockerContext> ContextFactory { get; set; }

        Task HandleUserRequest(Update messageInfo, TelegramBotClient _client);

        Chat Chat { get; set; }
    }
}