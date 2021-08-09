using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Measuretype
    {
        public Measuretype()
        {
            Measureranges = new HashSet<Measurerange>();
            Measures = new HashSet<Measure>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public Guid? Preferreddevicetype { get; set; }

        public virtual Devicetype PreferreddevicetypeNavigation { get; set; }
        public virtual ICollection<Measurerange> Measureranges { get; set; }
        public virtual ICollection<Measure> Measures { get; set; }
    }
}
