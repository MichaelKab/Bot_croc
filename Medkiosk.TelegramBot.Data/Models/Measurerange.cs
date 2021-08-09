using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Measurerange
    {
        public Measurerange()
        {
            Measures = new HashSet<Measure>();
            PgroupMeasureranges = new HashSet<PgroupMeasurerange>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Rangename { get; set; }
        public string Comment { get; set; }
        public double? Minvalue { get; set; }
        public double? Maxvalue { get; set; }
        public bool Isfail { get; set; }
        public string Color { get; set; }
        public bool? Isarchive { get; set; }
        public int? Priority { get; set; }
        public Guid Devicetype { get; set; }
        public Guid Measuretype { get; set; }

        public virtual Devicetype DevicetypeNavigation { get; set; }
        public virtual Measuretype MeasuretypeNavigation { get; set; }
        public virtual ICollection<Measure> Measures { get; set; }
        public virtual ICollection<PgroupMeasurerange> PgroupMeasureranges { get; set; }
    }
}
