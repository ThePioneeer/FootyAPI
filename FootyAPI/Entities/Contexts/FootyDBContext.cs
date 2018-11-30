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
    }
}
