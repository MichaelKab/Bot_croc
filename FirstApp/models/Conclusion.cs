using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Conclusion
    {
        public Conclusion()
        {
            ExaminationConclusions = new HashSet<ExaminationConclusion>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Comment { get; set; }
        public int? Decision { get; set; }
        public Guid? Person { get; set; }
        public Guid Role { get; set; }
        public string Signaturehash { get; set; }
        public Guid? Prohibitreason { get; set; }

        public virtual Person PersonNavigation { get; set; }
        public virtual Prohibitreason ProhibitreasonNavigation { get; set; }
        public virtual Role RoleNavigation { get; set; }
        public virtual ICollection<ExaminationConclusion> ExaminationConclusions { get; set; }
    }
}
