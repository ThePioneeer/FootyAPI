namespace FootyAPI.DAL.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int AssistByPlayerId { get; set; }
        public int TeamId { get; set; }
        public string GoalTime { get; set; }
        public string GoalType { get; set; }
        public int CompetitionId { get; set; }
        public string GoalSchedule { get; set; }
        public int GoalHalf { get; set; }
    }
}
