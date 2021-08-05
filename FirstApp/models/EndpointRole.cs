using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class EndpointRole
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Endpoint Object { get; set; }
        public virtual Role ValueNavigation { get; set; }
    }
}
