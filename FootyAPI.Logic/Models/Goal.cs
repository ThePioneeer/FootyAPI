namespace FootyAPI.Logic.Models
{
    public enum GoalType
    {
        Normal,
        FK,
        Penalty,
        OG
    }

    public class Goal
    {
        public Player Player { get; set; }
        public Player Assist { get; set; }
        public int ScoringMinute { get; set; }
        public GoalType GoalType { get; set; }
        public int ScoringHalf { get; set; }
    }
}