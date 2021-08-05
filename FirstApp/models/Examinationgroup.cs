using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Examinationgroup
    {
        public Examinationgroup()
        {
            ExaminationExaminationgroups = new HashSet<ExaminationExaminationgroup>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ExaminationExaminationgroup> ExaminationExaminationgroups { get; set; }
    }
}
