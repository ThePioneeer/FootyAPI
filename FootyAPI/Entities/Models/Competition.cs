namespace FootyAPI.Entities.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompetitionType { get; set; }
        public string Description { get; set; }
        public string Season { get; set; }
    }    
}