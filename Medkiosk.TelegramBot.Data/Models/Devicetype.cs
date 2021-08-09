using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Devicetype
    {
        public Devicetype()
        {
            Devices = new HashSet<Device>();
            Measureranges = new HashSet<Measurerange>();
            Measures = new HashSet<Measure>();
            Measuretypes = new HashSet<Measuretype>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public TimeSpan? Serviceperiod { get; set; }
        public int? Measureresource { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Measurerange> Measureranges { get; set; }
        public virtual ICollection<Measure> Measures { get; set; }
        public virtual ICollection<Measuretype> Measuretypes { get; set; }
    }
}
