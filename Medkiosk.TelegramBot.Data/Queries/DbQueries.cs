using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Croc.Medkiosk.TelegramBot.Data.Models;
using Medkiosk.TelegramBot.Core.Exceptions;
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

        public async Task EditPassword(string hashStr, string telegtamId)
        {
            /*Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.RollingFile(basedir + "/Logs/log-{Date}.txt")

                .CreateLogger()*/
            using (var db = ContextFactory.CreateDbContext())
            {
                var checkExist =
                    await db.Telegramidentities.FirstOrDefaultAsync(p =>
                        p.Telegramid == telegtamId);
                var passwList = await db.Passwords.Where(p =>
                    p.Authenticity == checkExist.Authenticity).ToListAsync();
                if (passwList.Count > 1)
                {
                    Logger.LogError($"User {checkExist.Authenticity} has a lot of passwords");
                }

                var passw = passwList.FirstOrDefault();
                if (passw != null)
                {
                    passw.Flags = 1;
                    passw.Value = hashStr;
                }
                else
                {
                    var password = new Password { };
                    password.Authenticity = checkExist.Authenticity;
                    password.Flags = 1;
                    password.Value = hashStr;
                    await db.Passwords.AddAsync(password);
                }

                await db.SaveChangesAsync();

                



            }
        }

        public bool CheckRegisteredTelegramId(string telegtamId)
        {
            using (var db = ContextFactory.CreateDbContext())
            {
                var checkExist =
                    db.Telegramidentities.FirstOrDefault(p =>
                        p.Telegramid == telegtamId);
                if (checkExist != null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}