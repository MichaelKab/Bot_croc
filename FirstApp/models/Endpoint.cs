using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Endpoint
    {
        public Endpoint()
        {
            EndpointRoles = new HashSet<EndpointRole>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool? Authrequired { get; set; }
        public Guid Endpointgroup { get; set; }

        public virtual Endpointgroup EndpointgroupNavigation { get; set; }
        public virtual ICollection<EndpointRole> EndpointRoles { get; set; }
    }
}
