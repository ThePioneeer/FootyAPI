using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootyAPI.Entities.Contexts
{
    public class FootyDBContext : DbContext
    {
        public FootyDBContext(DbContextOptions<FootyDBContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Models.Action> Action { get; set; }
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Fixture> Fixture { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Lineup> Lineup { get; set; }
        public DbSet<Goal> Goal { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}
