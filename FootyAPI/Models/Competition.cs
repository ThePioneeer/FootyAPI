namespace FootyAPI.Models
{
    public enum CompetitionType
    {
        Rahvaliiga = 1,
        GrandLiiga = 2
    }

    public class Competition
    {
        public int Id { get; set; }
        public int CompetitionTypeId { get; set; }
    }

    
}