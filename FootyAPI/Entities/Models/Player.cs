using System;

namespace FootyAPI.Entities.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public DateTime Birthday { get; set; }
        public int Number { get; set; }
        public int PositionId { get; set; }
        public int TeamId { get; set; }
        public string Country { get; set; }
    }
}
