using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Block
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Comment { get; set; }
        public DateTime? Unblockdt { get; set; }
        public Guid? Unblockedperson { get; set; }
        public Guid? Examination { get; set; }
        public Guid Patient { get; set; }
        public string Creationcomment { get; set; }
        public DateTime? Creationdt { get; set; }
        public Guid? Creator { get; set; }

        public virtual Person CreatorNavigation { get; set; }
        public virtual Examination ExaminationNavigation { get; set; }
        public virtual Person PatientNavigation { get; set; }
        public virtual Person UnblockedpersonNavigation { get; set; }
    }
}
