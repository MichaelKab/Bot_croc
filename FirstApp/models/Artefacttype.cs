using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Artefacttype
    {
        public Artefacttype()
        {
            Artefacts = new HashSet<Artefact>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Artefact> Artefacts { get; set; }
    }
}
