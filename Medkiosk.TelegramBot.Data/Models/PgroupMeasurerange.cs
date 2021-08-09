using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class PgroupMeasurerange
    {
        public Guid Objectid { get; set; }
        public Guid Value { get; set; }

        public virtual Pgroup Object { get; set; }
        public virtual Measurerange ValueNavigation { get; set; }
    }
}
