using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Examination
    {
        public Examination()
        {
            Answers = new HashSet<Answer>();
            Blocks = new HashSet<Block>();
            Events = new HashSet<Event>();
            ExaminationArtefacts = new HashSet<ExaminationArtefact>();
            ExaminationConclusions = new HashSet<ExaminationConclusion>();
            ExaminationExaminationgroups = new HashSet<ExaminationExaminationgroup>();
            Measures = new HashSet<Measure>();
        }

        public Guid Objectid { get; set; }
        public DateTime? Dt { get; set; }
        public int? Status { get; set; }
        public Guid Patient { get; set; }
        public Guid? Terminal { get; set; }
        public Guid? Employee { get; set; }
        public Guid? Software { get; set; }
        public DateTime? Finishdt { get; set; }
        public int? Type { get; set; }
        public DateTime? Enqueuedt { get; set; }
        public long Ts { get; set; }
        public Guid? Shift { get; set; }
        public int? Accessstatus { get; set; }

        public virtual Person EmployeeNavigation { get; set; }
        public virtual Person PatientNavigation { get; set; }
        public virtual Shift ShiftNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
        public virtual Terminal TerminalNavigation { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Block> Blocks { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ExaminationArtefact> ExaminationArtefacts { get; set; }
        public virtual ICollection<ExaminationConclusion> ExaminationConclusions { get; set; }
        public virtual ICollection<ExaminationExaminationgroup> ExaminationExaminationgroups { get; set; }
        public virtual ICollection<Measure> Measures { get; set; }
    }
}
