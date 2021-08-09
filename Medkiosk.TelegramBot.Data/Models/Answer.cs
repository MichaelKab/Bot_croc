using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Answer
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Dt { get; set; }
        public long Value { get; set; }
        public DateTime? Validity { get; set; }
        public string Comment { get; set; }
        public Guid Question { get; set; }
        public Guid Examination { get; set; }

        public virtual Examination ExaminationNavigation { get; set; }
        public virtual Question QuestionNavigation { get; set; }
    }
}
