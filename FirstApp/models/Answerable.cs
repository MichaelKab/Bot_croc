﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp.Models
{
    public partial class Answerable
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public Guid Person { get; set; }
        public Guid Orgunit { get; set; }
        public Guid Type { get; set; }

        public virtual Orgunit OrgunitNavigation { get; set; }
        public virtual Person PersonNavigation { get; set; }
        public virtual Answerabletype TypeNavigation { get; set; }
    }
}
