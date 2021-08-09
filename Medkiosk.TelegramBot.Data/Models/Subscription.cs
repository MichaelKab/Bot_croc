using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Subscription
    {
        public Subscription()
        {
            NotificationsendertypeSubscriptions = new HashSet<NotificationsendertypeSubscription>();
            SubscriptionOrgunits = new HashSet<SubscriptionOrgunit>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public Guid Person { get; set; }
        public bool? Enabled { get; set; }
        public Guid Eventtype { get; set; }
        public int Channel { get; set; }

        public virtual Eventtype EventtypeNavigation { get; set; }
        public virtual Person PersonNavigation { get; set; }
        public virtual ICollection<NotificationsendertypeSubscription> NotificationsendertypeSubscriptions { get; set; }
        public virtual ICollection<SubscriptionOrgunit> SubscriptionOrgunits { get; set; }
    }
}
