namespace Medkiosk.TelegramBot.Core.Enums
{
    public enum PasswordFlags
    {
		/// <summary>
        /// Не задано
        /// </summary>
        Empty = 0,

        /// <summary>
        /// Хэширован
        /// </summary>
        Hashed = 1,

        /// <summary>
        /// Временный
        /// </summary>
        Temporary = 2,
	}
}