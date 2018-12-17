using System;
using System.Linq;
using FootyAPI.Entities.Contexts;
using FootyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootyAPI.Logic
{
    public class DbManager : IDbManager
    {
        private readonly FootyDBContext _context;

        public DbManager(FootyDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddPlayer(Player player)
        {
            var playerEntity = new Entities.Player
            {
                Number = player.Number,
                PlayerName = player.Name,
                Birthday = player.Birthday,
                Country = player.Country
            };

            _context.Players.Add(playerEntity);
            _context.SaveChangesAsync();
        }

        public void AddMatch(Match match)
        {
            var score = match.Score.Split(":");
            var result = "";
            if (Convert.ToInt32(score[0]) > Convert.ToInt32(score[1]))
            {
                result = "Win";
            } else if (Convert.ToInt32(score[1]) > Convert.ToInt32(score[0]))
            {
                result = "Loss";
            }
            else
            {
                result = "Draw";
            }

            var homeTeamId = _context.Teams.FirstOrDefaultAsync(x => x.Name == match.HomeTeam.Name).Id;
            var awayTeamId = _context.Teams.FirstOrDefaultAsync(x => x.Name == match.AwayTeam.Name).Id;
            var venueId = _context.Venues.FirstOrDefaultAsync(x => x.Name == match.Venue.Name).Id;
            var competitionId = _context.Competitions.FirstOrDefaultAsync(x => x.Name == match.Competition.Name).Id;
            var playerOfTheMatch = _context.Players.FirstOrDefaultAsync(x => x.PlayerName == match.PlayerOfTheMatch).Id;

            var matchEntity = new Entities.Match
            {
                AwayTeamId = awayTeamId,
                TeamId = homeTeamId,
                HomeScore = Convert.ToInt32(score[0]),
                AwayScore = Convert.ToInt32(score[1]),
                VenueId = venueId,
                CompetitionId = competitionId,
                Date = match.DateTime,
                PlayerOfTheMatch = playerOfTheMatch,
                Result = result,
                ExtraTime = match.ExtraTime,
                PenaltyScore = match.PenaltyScore,
            };

            _context.Matches.Add(matchEntity);
            _context.SaveChangesAsync();
        }
    }
}
