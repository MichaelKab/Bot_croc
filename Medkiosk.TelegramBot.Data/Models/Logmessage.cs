using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Logmessage
    {
        public Guid Objectid { get; set; }
        public long Ts { get; set; }
        public int Level { get; set; }
        public string Message { get; set; }
        public DateTime? Dt { get; set; }
        public Guid? Device { get; set; }
        public string Thread { get; set; }
        public string Classname { get; set; }
        public string Methodname { get; set; }
        public int? Linenumber { get; set; }
        public Guid? Terminal { get; set; }
        public string Ip { get; set; }
        public Guid? Person { get; set; }

        public virtual Device DeviceNavigation { get; set; }
        public virtual Person PersonNavigation { get; set; }
        public virtual Terminal TerminalNavigation { get; set; }
    }
}
