using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            Answertemplates = new HashSet<Answertemplate>();
            InversePrevquestionNavigation = new HashSet<Question>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Text { get; set; }
        public int Flags { get; set; }
        public TimeSpan? Answervalidity { get; set; }
        public int Ordernumber { get; set; }
        public int Answertype { get; set; }
        public Guid? Prevquestion { get; set; }

        public virtual Question PrevquestionNavigation { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Answertemplate> Answertemplates { get; set; }
        public virtual ICollection<Question> InversePrevquestionNavigation { get; set; }
    }
}
