using System;
using System.Collections.Generic;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Document
    {
        public Document()
        {
            DocumentArtefacts = new HashSet<DocumentArtefact>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Number { get; set; }
        public Guid Type { get; set; }
        public Guid Person { get; set; }

        public virtual Person PersonNavigation { get; set; }
        public virtual Documenttype TypeNavigation { get; set; }
        public virtual ICollection<DocumentArtefact> DocumentArtefacts { get; set; }
    }
}
