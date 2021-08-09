using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Conversation
    {
        public Conversation()
        {
            Events = new HashSet<Event>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public DateTime? Dt { get; set; }
        public int Number { get; set; }
        public string Dialogstate { get; set; }
        public int Status { get; set; }
        public Guid Person { get; set; }
        public Guid? Event { get; set; }
        public Guid Eventtype { get; set; }

        public virtual Event EventNavigation { get; set; }
        public virtual Eventtype EventtypeNavigation { get; set; }
        public virtual Person PersonNavigation { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
