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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SeasonLeague>()
                .HasKey(e => new { e.SeasonId, e.CountryId });

        }

        //define table nam to be managed by EF Core
        public DbSet<Season> Season { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<WeekRanking> WeekRanking { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<SeasonLeague> SeasonLeague { get; set; }
    }
}
