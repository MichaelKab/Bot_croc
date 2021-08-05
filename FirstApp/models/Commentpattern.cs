using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Commentpattern
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Value { get; set; }
        public int? Number { get; set; }
        public Guid? Prohibitreason { get; set; }

        public virtual Prohibitreason ProhibitreasonNavigation { get; set; }
    }
}
