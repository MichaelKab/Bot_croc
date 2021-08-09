using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Doctoractivitystatus
    {
        public Doctoractivitystatus()
        {
            Terminals = new HashSet<Terminal>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime Updateddt { get; set; }
        public bool? Assignautomatically { get; set; }
        public Guid Doctor { get; set; }

        public virtual Person DoctorNavigation { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
