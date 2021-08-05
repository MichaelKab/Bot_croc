using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class ExaminationConclusion
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Examination Object { get; set; }
        public virtual Conclusion ValueNavigation { get; set; }
    }
}
