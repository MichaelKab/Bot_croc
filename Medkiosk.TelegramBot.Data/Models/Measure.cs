using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Measure
    {
        public Measure()
        {
            Calcvalues = new HashSet<Calcvalue>();
            Meterings = new HashSet<Metering>();
            Pupilparameters = new HashSet<Pupilparameter>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Dt { get; set; }
        public bool Isfail { get; set; }
        public int? Flags { get; set; }
        public string Value { get; set; }
        public string Discr { get; set; }
        public Guid Examination { get; set; }
        public Guid? Measurerange { get; set; }
        public Guid Devicetype { get; set; }
        public Guid Measuretype { get; set; }

        public virtual Devicetype DevicetypeNavigation { get; set; }
        public virtual Examination ExaminationNavigation { get; set; }
        public virtual Measurerange MeasurerangeNavigation { get; set; }
        public virtual Measuretype MeasuretypeNavigation { get; set; }
        public virtual Pupilmeasure Pupilmeasure { get; set; }
        public virtual ICollection<Calcvalue> Calcvalues { get; set; }
        public virtual ICollection<Metering> Meterings { get; set; }
        public virtual ICollection<Pupilparameter> Pupilparameters { get; set; }
    }
}
