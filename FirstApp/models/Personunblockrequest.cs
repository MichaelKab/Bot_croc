using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Personunblockrequest
    {
        public Guid Objectid { get; set; }
        public Guid Persontounblock { get; set; }

        public virtual Actionrequest Object { get; set; }
        public virtual Person PersontounblockNavigation { get; set; }
    }
}
