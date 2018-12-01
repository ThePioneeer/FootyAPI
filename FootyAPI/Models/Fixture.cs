using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Models
{
    public class Fixture
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int GameId { get; set; }
        public DateTime Date { get; set; }
        public int VenueId { get; set; }
    }
}
