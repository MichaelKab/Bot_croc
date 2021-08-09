﻿using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Rolesubscription
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public int Subscriptionchannel { get; set; }
        public bool Enabledbydefault { get; set; }
        public Guid Role { get; set; }
        public Guid Eventtype { get; set; }

        public virtual Eventtype EventtypeNavigation { get; set; }
        public virtual Role RoleNavigation { get; set; }
    }
}
