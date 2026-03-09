using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBaseball.Models;

namespace RazorPagesBaseball.Data
{
    public class RazorPagesBaseballContext : DbContext
    {
        public RazorPagesBaseballContext (DbContextOptions<RazorPagesBaseballContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBaseball.Models.Game> Game { get; set; } = default!;
    }
}
