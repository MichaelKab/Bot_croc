﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class PersonPgroup
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Person Object { get; set; }
        public virtual Pgroup ValueNavigation { get; set; }
    }
}
