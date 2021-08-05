using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Authenticity
    {
        public Authenticity()
        {
            Passwords = new HashSet<Password>();
            Telegramidentities = new HashSet<Telegramidentity>();
        }

        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public string Value { get; set; }
        public Guid Person { get; set; }
        public Guid Type { get; set; }

        public virtual Person PersonNavigation { get; set; }
        public virtual Authenticitytype TypeNavigation { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }
        public virtual ICollection<Telegramidentity> Telegramidentities { get; set; }
    }
}
