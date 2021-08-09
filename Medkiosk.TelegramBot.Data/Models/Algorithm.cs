using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Algorithm
    {
        public Algorithm()
        {
            SoftwareDssalgorithmNavigations = new HashSet<Software>();
            SoftwareValuealgorithmNavigations = new HashSet<Software>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime Createddt { get; set; }
        public int? Type { get; set; }
        public string Version { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Software> SoftwareDssalgorithmNavigations { get; set; }
        public virtual ICollection<Software> SoftwareValuealgorithmNavigations { get; set; }
    }
}
