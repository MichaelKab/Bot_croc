using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class RoleAnswerabletype
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Role Object { get; set; }
        public virtual Answerabletype ValueNavigation { get; set; }
    }
}
