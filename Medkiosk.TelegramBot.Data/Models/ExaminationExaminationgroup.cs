using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class ExaminationExaminationgroup
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Examination Object { get; set; }
        public virtual Examinationgroup ValueNavigation { get; set; }
    }
}
