using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.SetPassword
{
    public class PasswordInvitation : Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
            var text = messageInfo.Message.Text;

            var setResult = await DbQueries.SetPassword(
                text,
                messageInfo.Message.Chat.Id.ToString());

            if (setResult)
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Пароль успешно сохранён");
                Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries)
                {
                    Chat = Chat
                };
                await Chat.CurrentMessage.InitMessage(messageInfo, client);
            }
            else
            {
                await client.SendTextMessageAsync(
                    messageInfo.Message.Chat.Id, 
                    "Пароль должен содержать более 8 символов и по крайней мере одну " +
                    "строчную, одну заглавную букву и одну цифру");
            }
        }

        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            var button = AddCancellableMessage();
            await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Отправьте пароль", replyMarkup: button);
        }

        public PasswordInvitation(IDbContextFactory<newmed2_dockerContext> contextFactory, DbQueries dbQueries) : base(
            contextFactory, dbQueries)
        {
        }
    }
}
