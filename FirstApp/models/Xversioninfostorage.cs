using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Xversioninfostorage
    {
        public string Version { get; set; }
        public string Module { get; set; }
        public DateTime? Appliedat { get; set; }
        public string Description { get; set; }
    }
}
