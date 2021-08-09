using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Artefacts = new HashSet<Artefact>();
            Examinations = new HashSet<Examination>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Startdt { get; set; }
        public DateTime? Finishdt { get; set; }
        public Guid Person { get; set; }

        public virtual Person PersonNavigation { get; set; }
        public virtual ICollection<Artefact> Artefacts { get; set; }
        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
