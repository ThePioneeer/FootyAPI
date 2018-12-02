using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootyAPI.Entities.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int MatchId{ get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public int CompetitionId { get; set; }
        public int BookingTime { get; set; }
        public string BookingType { get; set; }
        public string SentOff { get; set; }
        public string PlaySchedule { get; set; }
        public int PlayHalf { get; set; }
        public string Comments { get; set; }
    }
}
