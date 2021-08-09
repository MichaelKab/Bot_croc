using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class SubscriptionOrgunit
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Subscription Object { get; set; }
        public virtual Orgunit ValueNavigation { get; set; }
    }
}
