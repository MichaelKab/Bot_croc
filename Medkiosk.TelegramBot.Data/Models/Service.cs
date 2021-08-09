using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Service
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime Dt { get; set; }
        public Guid Device { get; set; }
        public Guid Engineer { get; set; }

        public virtual Device DeviceNavigation { get; set; }
        public virtual Person EngineerNavigation { get; set; }
    }
}
