using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Notificationsendertype
    {
        public Notificationsendertype()
        {
            NotificationsendertypeSubscriptions = new HashSet<NotificationsendertypeSubscription>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<NotificationsendertypeSubscription> NotificationsendertypeSubscriptions { get; set; }
    }
}
