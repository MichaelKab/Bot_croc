using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Metering
    {
        public Metering()
        {
            Additionalvalues = new HashSet<Additionalvalue>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public bool Isleft { get; set; }
        public double Time { get; set; }
        public double D { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Alpha { get; set; }
        public bool Isoriginal { get; set; }
        public Guid Measure { get; set; }

        public virtual Measure MeasureNavigation { get; set; }
        public virtual ICollection<Additionalvalue> Additionalvalues { get; set; }
    }
}
