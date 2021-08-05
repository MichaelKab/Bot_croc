using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Pupilconfig
    {
        public Pupilconfig()
        {
            PupilconfigArtefacts = new HashSet<PupilconfigArtefact>();
            Pupilmeasures = new HashSet<Pupilmeasure>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Creationdt { get; set; }
        public int? Flashduration { get; set; }
        public int? Irleft { get; set; }
        public int? Irright { get; set; }
        public int? Gain { get; set; }
        public int? Commonbrightness { get; set; }
        public bool? Iscurrent { get; set; }
        public int? Position0x { get; set; }
        public int? Position0y { get; set; }
        public int? Position1x { get; set; }
        public int? Position1y { get; set; }
        public string Comment { get; set; }
        public Guid Device { get; set; }
        public Guid Software { get; set; }

        public virtual Device DeviceNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
        public virtual ICollection<PupilconfigArtefact> PupilconfigArtefacts { get; set; }
        public virtual ICollection<Pupilmeasure> Pupilmeasures { get; set; }
    }
}
