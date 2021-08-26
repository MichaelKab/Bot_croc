namespace Medkiosk.TelegramBot.Core.Enums
{
    public enum PersonFlags
    {
		/// <summary>
        /// Не задано
        /// </summary>
        Empty = 0,

        /// <summary>
        /// NeedAttentionCheck
        /// </summary>
        NeedAttentionCheck = 1,

        /// <summary>
        /// Заблокирован
        /// </summary>
        Blocked = 2,

        /// <summary>
        /// Архивный
        /// </summary>
        IsArchive = 4,
	}
}