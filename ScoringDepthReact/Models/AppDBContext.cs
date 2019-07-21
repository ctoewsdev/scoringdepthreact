using Microsoft.EntityFrameworkCore;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models
{
    //Interface between Models and the DB
    public class AppDbContext : DbContext
    {
        //construct instance of options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.SetInitializer<AppDbContext>(new CreateDatabaseIfNotExists<AppDbContext>());
        }

      //define table nam to be managed by EF Core
        public DbSet<Country> Country { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
