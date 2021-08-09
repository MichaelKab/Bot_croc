using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Actionrequest
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Createddt { get; set; }
        public DateTime? Updateddt { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string Discr { get; set; }
        public Guid Creator { get; set; }
        public Guid? Responsibleperson { get; set; }

        public virtual Person CreatorNavigation { get; set; }
        public virtual Person ResponsiblepersonNavigation { get; set; }
        public virtual Personunblockrequest Personunblockrequest { get; set; }
    }
}
