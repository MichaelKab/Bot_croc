using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Xloblinkcount
    {
        public Xloblinkcount()
        {
            Artefacts = new HashSet<Artefact>();
            Users = new HashSet<User>();
        }

        public uint Lobid { get; set; }
        public int Linkcount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<Artefact> Artefacts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
