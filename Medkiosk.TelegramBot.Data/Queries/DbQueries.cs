using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Medkiosk.TelegramBot.Core.Enums;
using Medkiosk.TelegramBot.Core.Exceptions;
using Medkiosk.TelegramBot.Core.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Croc.Medkiosk.TelegramBot.Data.Queries
{
    public class DbQueries : QueriesBase
    {
        public DbQueries(IDbContextFactory<newmed2_dockerContext> contextFactory, ILogger<DbQueries> logger)
            : base(contextFactory, logger)
        {
        }

        /// <summary>
        /// Зарегистрировать новый TelegramId 
        /// </summary>
        public async Task RegisterTelegramId(string phoneNumber, string telegtamId)
        {
            using (var db = ContextFactory.CreateDbContext())
            {
                var numberFromTg = string.Join("", phoneNumber.Where(char.IsDigit).Skip(1));

                var pattern = @$"{numberFromTg.Substring(0, 3)}\D*{numberFromTg.Substring(3, 3)}\D*" +
                                 @$"{numberFromTg.Substring(6, 2)}\D*{numberFromTg.Substring(8, 2)}$";
                var authenticities = await db.Authenticities.Where(b => Regex.IsMatch(b.Value, pattern))
                    .ToListAsync();


                if (authenticities.Count > 1)
                {
                    Logger.LogError("Обнаружено дублирование номера {0} при поптыке регистрации telegramId {1}", 
                        phoneNumber, telegtamId);

                    throw new BotBusinessLogicException(
                        "При регистрации в системе обнаружено дублирование номеров телефонов. " + 
                        "Для завершения регистрации обратитесь к администратору.");
                }
                else
                {
                    var authenticity = authenticities.FirstOrDefault();
                    if (authenticity == null)
                    {
                        var telegramidentity = new Telegramidentity
                            {
                                Objectid = Guid.NewGuid(),
                                Telegramid = telegtamId,
                                Authenticity = authenticity.Objectid
                            };

                            await db.Telegramidentities.AddAsync(telegramidentity);
                            await db.SaveChangesAsync();
                        
                    }
                    else
                    {
                        throw new BotBusinessLogicException(
                            "Данный номер телефона не найден в системе. " +
                            "Для завершения регистрации обратитесь к администратору.");
                    }
                }
            }
        }

        /// <summary>
        /// Установить новое значение пароля
        /// </summary>
        /// <param name="value">Новое занчение пароля</param>
        /// <param name="telegtamId">TelegramId пользователя</param>
        /// <returns>Признак соответствия пароля требованиям</returns>
        public async Task<bool> SetPassword(string value, string telegtamId)
        {
            if (string.IsNullOrEmpty(telegtamId)) throw new ArgumentNullException(nameof(telegtamId));
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));

            if (!CheckPasswordRequirements(value)) return false;
            var hashStr = CryptoUtils.GetPasswordHash(value);

            using (var db = ContextFactory.CreateDbContext())
            {
                var authenticity =
                    (await db.Telegramidentities.FirstOrDefaultAsync(p =>
                        p.Telegramid == telegtamId)).Authenticity;
                var passwList = await db.Passwords.Where(p =>
                    p.Authenticity == authenticity).ToListAsync();

                if (passwList.Count > 1)
                {
                    db.Passwords.RemoveRange(passwList);
                }
                else if (passwList.Count == 1)
                {
                    var password = passwList.First();
                    password.Flags = (int)PasswordFlags.Hashed;
                    password.Value = hashStr;
                }
                
                if (passwList.Count != 1)
                {
                    var password = new Password
                    {
                        Objectid = Guid.NewGuid(),
                        Authenticity = authenticity, 
                        Flags = (int)PasswordFlags.Hashed, 
                        Value = hashStr
                    };
                    await db.Passwords.AddAsync(password);
                }

                await db.SaveChangesAsync();
                return true;
            }
        }

        private bool CheckPasswordRequirements(string password)
        {
            return password.Length >= 8 
                   && Regex.IsMatch(password, @"[A-Z]") 
                   && Regex.IsMatch(password, @"\d") 
                   && Regex.IsMatch(password, @"[a-z]");
        }

        /// <summary>
        /// Проверить что пользователь зарегистрирован
        /// </summary>
        /// <param name="telegtamId"></param>
        public async Task<bool> CheckUserIsRegistered(string telegtamId)
        {
            using (var db = ContextFactory.CreateDbContext())
            {
                return await db.Telegramidentities
                    .AnyAsync(p => p.Telegramid == telegtamId);
            }
        }
    }
}