using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class PupilconfigArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }
        public int K { get; set; }

        public virtual Pupilconfig Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
