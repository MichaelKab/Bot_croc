using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Pupilparameter
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public double? Value { get; set; }
        public double? Deviation { get; set; }
        public double? Valuestd { get; set; }
        public double? Valueaverage { get; set; }
        public int Type { get; set; }
        public int Unit { get; set; }
        public bool? Isleft { get; set; }
        public Guid Measure { get; set; }

        public virtual Measure MeasureNavigation { get; set; }
    }
}
