using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Devicestatus
    {
        public Devicestatus()
        {
            Devices = new HashSet<Device>();
            Terminals = new HashSet<Terminal>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public int Currentstatus { get; set; }
        public DateTime? Updateddt { get; set; }
        public string Ip { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
    }
}
