﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class PgroupMeasurerange
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Pgroup Object { get; set; }
        public virtual Measurerange ValueNavigation { get; set; }
    }
}
