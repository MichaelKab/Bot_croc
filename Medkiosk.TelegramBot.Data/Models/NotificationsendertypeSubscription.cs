using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class NotificationsendertypeSubscription
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Notificationsendertype Object { get; set; }
        public virtual Subscription ValueNavigation { get; set; }
    }
}
