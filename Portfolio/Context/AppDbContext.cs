using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
