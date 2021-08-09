using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Personunblockrequest
    {
        public Guid Objectid { get; set; }
        public Guid Persontounblock { get; set; }

        public virtual Actionrequest Object { get; set; }
        public virtual Person PersontounblockNavigation { get; set; }
    }
}
