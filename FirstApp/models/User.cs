using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class User
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public DateTime? Created { get; set; }
        public string Password { get; set; }
        public uint? Photo { get; set; }

        public virtual Xloblinkcount PhotoNavigation { get; set; }
    }
}
