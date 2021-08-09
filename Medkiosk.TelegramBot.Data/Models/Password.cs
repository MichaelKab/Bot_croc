using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Password
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Value { get; set; }
        public int? Flags { get; set; }
        public Guid Authenticity { get; set; }

        public virtual Authenticity AuthenticityNavigation { get; set; }
    }
}
