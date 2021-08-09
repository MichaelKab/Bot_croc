using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Authenticitytype
    {
        public Authenticitytype()
        {
            Authenticities = new HashSet<Authenticity>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Authenticity> Authenticities { get; set; }
    }
}
