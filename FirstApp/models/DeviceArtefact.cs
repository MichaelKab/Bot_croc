using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class DeviceArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Device Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
