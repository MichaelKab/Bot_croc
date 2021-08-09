using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class PersonArtefact
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Person Object { get; set; }
        public virtual Artefact ValueNavigation { get; set; }
    }
}
