using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Role
    {
        public Role()
        {
            Conclusions = new HashSet<Conclusion>();
            EndpointRoles = new HashSet<EndpointRole>();
            PersonRoles = new HashSet<PersonRole>();
            RoleAnswerabletypes = new HashSet<RoleAnswerabletype>();
            Rolesubscriptions = new HashSet<Rolesubscription>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }

        public virtual ICollection<Conclusion> Conclusions { get; set; }
        public virtual ICollection<EndpointRole> EndpointRoles { get; set; }
        public virtual ICollection<PersonRole> PersonRoles { get; set; }
        public virtual ICollection<RoleAnswerabletype> RoleAnswerabletypes { get; set; }
        public virtual ICollection<Rolesubscription> Rolesubscriptions { get; set; }
    }
}
