using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Prohibitreason
    {
        public Prohibitreason()
        {
            Commentpatterns = new HashSet<Commentpattern>();
            Conclusions = new HashSet<Conclusion>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool? Isarchive { get; set; }

        public virtual ICollection<Commentpattern> Commentpatterns { get; set; }
        public virtual ICollection<Conclusion> Conclusions { get; set; }
    }
}
