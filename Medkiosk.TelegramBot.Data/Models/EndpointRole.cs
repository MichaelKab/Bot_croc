using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class EndpointRole
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Endpoint Object { get; set; }
        public virtual Role ValueNavigation { get; set; }
    }
}
