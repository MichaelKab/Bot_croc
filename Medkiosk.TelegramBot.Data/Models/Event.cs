using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Event
    {
        public Event()
        {
            Conversations = new HashSet<Conversation>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public Guid Eventtype { get; set; }
        public Guid? Examination { get; set; }
        public DateTime Invokedt { get; set; }
        public bool Invoked { get; set; }
        public bool? Isactiveproblem { get; set; }
        public Guid? Terminal { get; set; }
        public Guid? Relatedconversation { get; set; }

        public virtual Eventtype EventtypeNavigation { get; set; }
        public virtual Examination ExaminationNavigation { get; set; }
        public virtual Conversation RelatedconversationNavigation { get; set; }
        public virtual Terminal TerminalNavigation { get; set; }
        public virtual ICollection<Conversation> Conversations { get; set; }
    }
}
