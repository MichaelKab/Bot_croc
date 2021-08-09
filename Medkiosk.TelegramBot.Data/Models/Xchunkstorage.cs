using System;

#nullable disable

namespace Croc.Medkiosk.TelegramBot.Data.Models
{
    public partial class Xchunkstorage
    {
        public string Chunkchainid { get; set; }
        public int Chunkindex { get; set; }
        public uint Chunkdata { get; set; }
        public DateTime Created { get; set; }
    }
}
