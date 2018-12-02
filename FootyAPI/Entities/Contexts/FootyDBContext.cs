using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyAPI.Entities.Models;
using FootyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootyAPI.Entities.Contexts
{
    public class FootyDBContext : DbContext
    {
        public FootyDBContext(DbContextOptions<FootyDBContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<PlayingPosition> PlayingPositions { get; set; }
    }
}
