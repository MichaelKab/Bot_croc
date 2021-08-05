using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Calcvalue
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public double? Time { get; set; }
        public double? Value { get; set; }
        public bool? Isleft { get; set; }
        public int? Type { get; set; }
        public Guid Measure { get; set; }

        public virtual Measure MeasureNavigation { get; set; }
    }
}
