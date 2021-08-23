using System;

namespace Medkiosk.TelegramBot.Core.Exceptions
{
    /// <summary>
    /// Исключение бизнес-логики бота
    /// </summary>
    public class BotBusinessLogicException : Exception
    {
        public BotBusinessLogicException(string message) 
            : base(message)
        {
        }
    }
}
