using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Documenttype
    {
        public Documenttype()
        {
            Documents = new HashSet<Document>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string Checkpattern { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
