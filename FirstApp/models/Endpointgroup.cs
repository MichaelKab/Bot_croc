using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Endpointgroup
    {
        public Endpointgroup()
        {
            Endpoints = new HashSet<Endpoint>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Prefix { get; set; }
        public string Method { get; set; }

        public virtual ICollection<Endpoint> Endpoints { get; set; }
    }
}
