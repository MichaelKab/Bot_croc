using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Telegramidentity
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Telegramid { get; set; }
        public Guid Authenticity { get; set; }

        public virtual Authenticity AuthenticityNavigation { get; set; }
    }
}
