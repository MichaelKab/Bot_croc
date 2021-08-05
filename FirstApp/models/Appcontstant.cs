using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Appcontstant
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Domaintype { get; set; }
        public string Name { get; set; }
        public Guid Value { get; set; }
        public string Shownvalue { get; set; }
        public string Shownfield { get; set; }
    }
}
