using System;

namespace FootyAPI.Entities.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        public int VenueId { get; set; }
        public DateTime Date { get; set; }
        public int TeamId { get; set; }
        public int AwayTeamId { get; set; }
        public string Result { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public string PenaltyScore { get; set; }
        public int PlayerofTheMatch { get; set; }
    }
}
