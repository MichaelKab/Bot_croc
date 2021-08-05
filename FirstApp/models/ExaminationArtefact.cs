using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class ExaminationArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Examination Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
