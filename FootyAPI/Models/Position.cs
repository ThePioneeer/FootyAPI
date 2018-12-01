namespace FootyAPI.Models
{
    public enum PositionCategory
    {
        Goalkeeper = 1,
        Defender = 2,
        Midfielder = 3,
        Attacker = 4
    }

    public class Position
    {
        public int Id { get; set; }
        public int PositionCategory { get; set; }
        public string PositionName { get; set; }
    }
}