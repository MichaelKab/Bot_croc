using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Xversioninfostorage
    {
        public string Version { get; set; }
        public string Module { get; set; }
        public DateTime? Appliedat { get; set; }
        public string Description { get; set; }
    }
}
