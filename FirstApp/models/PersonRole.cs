using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class PersonRole
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Person Object { get; set; }
        public virtual Role ValueNavigation { get; set; }
    }
}
