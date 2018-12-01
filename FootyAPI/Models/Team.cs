namespace FootyAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Venue HomeVenue { get; set; }
        public string HomePage { get; set; }
    }
}