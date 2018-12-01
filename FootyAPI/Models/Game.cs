namespace FootyAPI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int ManOftheMatch { get; set; }
        public int HomeTeamLinupId { get; set; }
        public int AwayTeamLinupId { get; set; }
    }
}