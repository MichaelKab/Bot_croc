using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Software
    {
        public Software()
        {
            Artefacts = new HashSet<Artefact>();
            Devices = new HashSet<Device>();
            Examinations = new HashSet<Examination>();
            Pupilconfigs = new HashSet<Pupilconfig>();
            Pupilmeasures = new HashSet<Pupilmeasure>();
            Terminals = new HashSet<Terminal>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public DateTime? Releasedt { get; set; }
        public Guid? Valuealgorithm { get; set; }
        public Guid? Dssalgorithm { get; set; }

        public virtual Algorithm DssalgorithmNavigation { get; set; }
        public virtual Algorithm ValuealgorithmNavigation { get; set; }
        public virtual ICollection<Artefact> Artefacts { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Examination> Examinations { get; set; }
        public virtual ICollection<Pupilconfig> Pupilconfigs { get; set; }
        public virtual ICollection<Pupilmeasure> Pupilmeasures { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
