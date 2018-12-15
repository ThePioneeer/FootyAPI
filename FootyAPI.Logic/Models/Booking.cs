namespace FootyAPI.Logic.Models
{
    public class Booking
    {
        public string CardType { get; set; }
        public Player Player { get; set; }
        public int FoulMinute { get; set; }
        public int FoulHalf { get; set; }
        public bool Removal { get; set; }
    }
}