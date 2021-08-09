using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Commentpattern
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Value { get; set; }
        public int? Number { get; set; }
        public Guid? Prohibitreason { get; set; }

        public virtual Prohibitreason ProhibitreasonNavigation { get; set; }
    }
}
