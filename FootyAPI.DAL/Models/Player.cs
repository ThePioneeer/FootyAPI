using System;

namespace FootyAPI.DAL.Models
{
    public class Player
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Number { get; set; }
        public Position Position { get; set; }
        public Team Team { get; set; }
        public string Country { get; set; }
    }
}
