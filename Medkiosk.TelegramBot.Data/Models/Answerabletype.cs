using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Answerabletype
    {
        public Answerabletype()
        {
            Answerables = new HashSet<Answerable>();
            RoleAnswerabletypes = new HashSet<RoleAnswerabletype>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Answerable> Answerables { get; set; }
        public virtual ICollection<RoleAnswerabletype> RoleAnswerabletypes { get; set; }
    }
}
