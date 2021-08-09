using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Additionalvalue
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public double Value { get; set; }
        public int Type { get; set; }
        public Guid Metering { get; set; }

        public virtual Metering MeteringNavigation { get; set; }
    }
}
