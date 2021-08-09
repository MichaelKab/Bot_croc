using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Telegramidentity
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Telegramid { get; set; }
        public Guid Authenticity { get; set; }

        public virtual Authenticity AuthenticityNavigation { get; set; }
    }
}
