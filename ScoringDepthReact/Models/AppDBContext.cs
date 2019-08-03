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
            modelBuilder.Entity<Season>()
                .Property(x => x.SeasonId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Season>()
                .HasKey(x => new { YearRegionId = x.SeasonId });


            modelBuilder.Entity<SeasonLeague>()
                .Property(x => x.SeasonLeagueId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SeasonLeague>()
                .HasKey(x => new { x.SeasonLeagueId });


            modelBuilder.Entity<TeamSeason>()
                .Property(x => x.TeamSeasonId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<TeamSeason>()
                .HasKey(x => new { x.TeamSeasonId});

            modelBuilder.Entity<SeasonRanking>()
                .Property(x => x.SeasonRankingId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SeasonRanking>()
                .HasKey(x => new { x.SeasonRankingId });


        }

        //define table nam to be managed by EF Core
        public DbSet<Year> Year { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<SeasonLeague> SeasonLeague { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Ranking> Ranking { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<SeasonRanking> SeasonRanking { get; set; }
        public DbSet<TeamSeason> TeamSeason { get; set; }
    }
}
