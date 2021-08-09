using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Pgroup
    {
        public Pgroup()
        {
            PersonPgroups = new HashSet<PersonPgroup>();
            PgroupMeasureranges = new HashSet<PgroupMeasurerange>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public bool Isdefault { get; set; }
        public int? Flags { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PersonPgroup> PersonPgroups { get; set; }
        public virtual ICollection<PgroupMeasurerange> PgroupMeasureranges { get; set; }
    }
}
