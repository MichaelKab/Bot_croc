using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Orgunit
    {
        public Orgunit()
        {
            Answerables = new HashSet<Answerable>();
            InverseParentNavigation = new HashSet<Orgunit>();
            People = new HashSet<Person>();
            SubscriptionOrgunits = new HashSet<SubscriptionOrgunit>();
            Terminals = new HashSet<Terminal>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? Manager { get; set; }
        public Guid? Parent { get; set; }
        public int? Flags { get; set; }
        public short? Timezone { get; set; }

        public virtual Person ManagerNavigation { get; set; }
        public virtual Orgunit ParentNavigation { get; set; }
        public virtual ICollection<Answerable> Answerables { get; set; }
        public virtual ICollection<Orgunit> InverseParentNavigation { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<SubscriptionOrgunit> SubscriptionOrgunits { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
