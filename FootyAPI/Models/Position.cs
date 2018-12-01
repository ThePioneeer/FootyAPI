namespace FootyAPI.Models
{
    public class PositionPositionCategory
    {
        public int Id { get; set; }
        public string PositionCategory { get; set; }
    }

    public class Position
    {
        public int Id { get; set; }
        public int PositionCategoryId { get; set; }
        public string PositionName { get; set; }
    }
}