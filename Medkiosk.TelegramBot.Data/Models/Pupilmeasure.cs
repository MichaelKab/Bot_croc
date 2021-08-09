using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Pupilmeasure
    {
        public Guid Objectid { get; set; }
        public double? Confidence { get; set; }
        public double? Score { get; set; }
        public int Error { get; set; }
        public Guid? Pupilconfig { get; set; }
        public Guid? Software { get; set; }
        public string Config { get; set; }

        public virtual Measure Object { get; set; }
        public virtual Pupilconfig PupilconfigNavigation { get; set; }
        public virtual Software SoftwareNavigation { get; set; }
    }
}
