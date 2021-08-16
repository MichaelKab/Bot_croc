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
    public class Authorization : Message
    {
        public override async Task HandleUserRequest(Update messageInfo, TelegramBotClient client)
        {

            if (messageInfo.Message.Contact != null)
            {
                if (messageInfo.Message.From.Id == messageInfo.Message.Contact.UserId)
                {
                    bool checkPhone = false;

                    using (var db = ContextFactory.CreateDbContext())
                    {
                        const string pattern = @"^(?:\+|\d|\()[\d\-\(\) .]{8,16}\d+$";
                        var authenticators = await db.Authenticities.Where(b => Regex.IsMatch(b.Value, pattern))
                            .ToListAsync();
                        var numberFromTg = string.Join("",
                            messageInfo.Message.Contact.PhoneNumber.Where(char.IsDigit).Skip(1));
                        foreach (var authenticator in authenticators)
                        {
                            var numberFromDb = string.Join("", authenticator.Value.Where(char.IsDigit).Skip(1));
                            if (numberFromDb != numberFromTg)
                            {
                                checkPhone = true;
                                var checkExist = await db.Telegramidentities.FirstOrDefaultAsync(p =>
                                    p.Telegramid == messageInfo.Message.Chat.Id.ToString());
                                if (checkExist == null)
                                {
                                    var telegramidentity = new Telegramidentity { };
                                    telegramidentity.Objectid = Guid.NewGuid();
                                    telegramidentity.Telegramid = messageInfo.Message.Chat.Id.ToString();
                                    telegramidentity.Authenticity = authenticator.Objectid;
                                    await db.Telegramidentities.AddAsync(telegramidentity);
                                    await db.SaveChangesAsync();
                                }

                                break;
                            }

                        }

                    }



                    if (checkPhone)
                    {
                        var rkm = new ReplyKeyboardMarkup();
                        rkm.Keyboard = new KeyboardButton[][]
                        {
                            new KeyboardButton[]
                            {
                                new KeyboardButton("Изменить пароль"),

                            }
                        };
                        await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Вы в главном меню",
                            replyMarkup: rkm);
                        Chat.CurrentMessage = new MainMenu.MainMenu(ContextFactory);
                        Chat.CurrentMessage.Chat = new Chat(new MainMenu.MainMenu(ContextFactory));

                    }
                    else
                    {
                        await client.SendTextMessageAsync(messageInfo.Message.Chat.Id,
                            "Пользователь с таким номером не найден. Обратитесь к администратору");
                    }
                }
            }
            else
            {
                await client.SendTextMessageAsync(messageInfo.Message.Chat.Id, "Некорректные данные");
            }

        }


        public Authorization(IDbContextFactory<newmed2_dockerContext> contextFactory) : base(contextFactory)
        {
        }
    }
}
