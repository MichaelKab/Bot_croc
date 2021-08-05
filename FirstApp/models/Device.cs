using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Device
    {
        public Device()
        {
            DeviceArtefacts = new HashSet<DeviceArtefact>();
            Logmessages = new HashSet<Logmessage>();
            Pupilconfigs = new HashSet<Pupilconfig>();
            Services = new HashSet<Service>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Sn { get; set; }
        public string Comment { get; set; }
        public Guid? Terminal { get; set; }
        public Guid Devicetype { get; set; }
        public Guid? Software { get; set; }
        public Guid? Status { get; set; }

        public virtual Devicetype DevicetypeNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
        public virtual Devicestatus StatusNavigation { get; set; }
        public virtual Terminal TerminalNavigation { get; set; }
        public virtual ICollection<DeviceArtefact> DeviceArtefacts { get; set; }
        public virtual ICollection<Logmessage> Logmessages { get; set; }
        public virtual ICollection<Pupilconfig> Pupilconfigs { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
