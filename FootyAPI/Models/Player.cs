using System;

namespace FootyAPI.Models
{
    public class Player
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Number { get; set; }
        public Team Team { get; set; }
        public string Country { get; set; }
        public int Goals { get; set; }
    }
}
