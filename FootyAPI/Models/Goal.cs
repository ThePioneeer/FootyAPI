using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int AssistPlayerId { get; set; }
        public int GameId { get; set; }
        public int Minute { get; set; }
    }
}
