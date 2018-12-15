using System.Collections.Generic;

namespace FootyAPI.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public string Coach { get; set; }
    }
}