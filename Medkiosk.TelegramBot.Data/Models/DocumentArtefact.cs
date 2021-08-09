using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class DocumentArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Document Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
