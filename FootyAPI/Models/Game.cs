namespace FootyAPI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public Player MVP { get; set; }
    }
}