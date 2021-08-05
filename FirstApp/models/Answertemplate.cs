using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Answertemplate
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int Mincommentlength { get; set; }
        public Guid Question { get; set; }

        public virtual Question QuestionNavigation { get; set; }
    }
}
