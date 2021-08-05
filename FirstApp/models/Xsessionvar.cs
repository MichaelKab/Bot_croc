using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Xsessionvar
    {
        public int Backendpid { get; set; }
        public string Variablename { get; set; }
        public string Variablevaluetext { get; set; }
        public int? Variablevalueint { get; set; }
    }
}
