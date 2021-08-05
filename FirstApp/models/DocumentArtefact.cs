using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class DocumentArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Document Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
