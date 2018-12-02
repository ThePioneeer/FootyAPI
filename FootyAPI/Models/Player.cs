using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
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
