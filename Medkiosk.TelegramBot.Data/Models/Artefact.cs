using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Artefact
    {
        public Artefact()
        {
            DeviceArtefacts = new HashSet<DeviceArtefact>();
            DocumentArtefacts = new HashSet<DocumentArtefact>();
            ExaminationArtefacts = new HashSet<ExaminationArtefact>();
            PersonArtefacts = new HashSet<PersonArtefact>();
            PupilconfigArtefacts = new HashSet<PupilconfigArtefact>();
            TerminalArtefacts = new HashSet<TerminalArtefact>();
        }

        public Guid Objectid { get; set; }
        public uint? Binary { get; set; }
        public DateTime? Dt { get; set; }
        public string Comment { get; set; }
        public Guid Type { get; set; }
        public Guid? Software { get; set; }
        public int? Flags { get; set; }
        public string Storageid { get; set; }
        public Guid? Shift { get; set; }
        public int? Number { get; set; }

        public virtual Xloblinkcount BinaryNavigation { get; set; }
        public virtual Shift ShiftNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
        public virtual Artefacttype TypeNavigation { get; set; }
        public virtual ICollection<DeviceArtefact> DeviceArtefacts { get; set; }
        public virtual ICollection<DocumentArtefact> DocumentArtefacts { get; set; }
        public virtual ICollection<ExaminationArtefact> ExaminationArtefacts { get; set; }
        public virtual ICollection<PersonArtefact> PersonArtefacts { get; set; }
        public virtual ICollection<PupilconfigArtefact> PupilconfigArtefacts { get; set; }
        public virtual ICollection<TerminalArtefact> TerminalArtefacts { get; set; }
    }
}
