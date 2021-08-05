using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Eventtype
    {
        public Eventtype()
        {
            Conversations = new HashSet<Conversation>();
            Events = new HashSet<Event>();
            Rolesubscriptions = new HashSet<Rolesubscription>();
            Subscriptions = new HashSet<Subscription>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan? Invokedelay { get; set; }

        public virtual ICollection<Conversation> Conversations { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Rolesubscription> Rolesubscriptions { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
