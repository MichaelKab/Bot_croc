using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data;
using Croc.Medkiosk.TelegramBot.Data.Queries;
using Medkiosk.TelegramBot.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Croc.Medkiosk.TelegramBot.Messaging.Conversation.StartChating
{
    public class Authorization : Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {
            if (messageInfo.Message.Contact == null)
            {
                await client.SendTextMessageAsync(
                    messageInfo.Message.Chat.Id, 
                    "Некорректные данные");
                return;
            }

            if (messageInfo.Message.From.Id != messageInfo.Message.Contact.UserId)
            {
                await client.SendTextMessageAsync(
                    messageInfo.Message.Chat.Id, 
                    "Отправленный контакт принадлежит другому пользователю");
                return;
            }

            try
            {
                await DbQueries.RegisterTelegramId(
                    messageInfo.Message.Contact.PhoneNumber,
                    messageInfo.Message.Chat.Id.ToString());
                Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory, DbQueries)
                {
                    Chat = new Chat(new MainMenu.MainMenu(ContextFactory, DbQueries))
                };
                await Chat.CurrentMessage.InitMessage(messageInfo, client);
            }

            catch (BotBusinessLogicException e)
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, e.Message);
            }
        }

        public override async Task InitMessage(Update messageInfo, TelegramBotClient client)
        {
            KeyboardButton button = KeyboardButton.WithRequestContact("Поделиться контактом");
            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(button);
            await client.SendTextMessageAsync(messageInfo.Message.Chat, "Для начала работы с ботом поделитесь контактом", replyMarkup: keyboard);
        }


        public Authorization(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            DbQueries dbQueries) 
            : base(contextFactory, dbQueries) { }
    }
}
