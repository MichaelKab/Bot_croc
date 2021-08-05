using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Service
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime Dt { get; set; }
        public Guid Device { get; set; }
        public Guid Engineer { get; set; }

        public virtual Device DeviceNavigation { get; set; }
        public virtual Person EngineerNavigation { get; set; }
    }
}
