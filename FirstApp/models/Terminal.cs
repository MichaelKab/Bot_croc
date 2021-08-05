using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Terminal
    {
        public Terminal()
        {
            Devices = new HashSet<Device>();
            Events = new HashSet<Event>();
            Examinations = new HashSet<Examination>();
            Logmessages = new HashSet<Logmessage>();
            TerminalArtefacts = new HashSet<TerminalArtefact>();
        }

        public Guid Objectid { get; set; }
        public string Comment { get; set; }
        public string Sn { get; set; }
        public Guid? Status { get; set; }
        public Guid? Doctoractivitystatus { get; set; }
        public long Ts { get; set; }
        public string Hardwareid { get; set; }
        public Guid? Orgunit { get; set; }
        public Guid? Software { get; set; }

        public virtual Doctoractivitystatus DoctoractivitystatusNavigation { get; set; }
        public virtual Orgunit OrgunitNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
        public virtual Devicestatus StatusNavigation { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Examination> Examinations { get; set; }
        public virtual ICollection<Logmessage> Logmessages { get; set; }
        public virtual ICollection<TerminalArtefact> TerminalArtefacts { get; set; }
    }
}
