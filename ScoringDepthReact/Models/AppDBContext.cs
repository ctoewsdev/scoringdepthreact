using Microsoft.EntityFrameworkCore;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models
{
    //Interface between Models and the DB Session
    public class AppDbContext : DbContext
    {
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

            modelBuilder.Entity<SeasonTeam>()
                .Property(x => x.SeasonTeamId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SeasonTeam>()
                .HasKey(x => new { x.SeasonTeamId });

            modelBuilder.Entity<TeamRanking>()
                .Property(x => x.TeamRankingId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<TeamRanking>()
                .HasKey(x => new { x.TeamRankingId });
        }

        //SQL Server tables to be managed by EF Core
        public DbSet<Year> Year { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<SeasonLeague> SeasonLeague { get; set; }
        public DbSet<SeasonTeam> SeasonTeam { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Ranking> Ranking { get; set; }
        public DbSet<TeamRanking> TeamRanking { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}