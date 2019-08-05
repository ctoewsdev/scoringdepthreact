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
                .HasKey(x => new { x.SeasonId });

            modelBuilder.Entity<SeasonLeague>()
                .Property(x => x.SeasonLeagueId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SeasonLeague>()
                .HasKey(x => new { x.SeasonLeagueId });

            modelBuilder.Entity<SeasonRanking>()
                .Property(x => x.SeasonRankingId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SeasonRanking>()
                .HasKey(x => new { x.SeasonRankingId });

            //    modelBuilder.Entity<TeamRanking>(entity => 

            //        entity.HasOne(d. => d.)
            //});

            //modelBuilder.Entity<TeamRanking>()
            //    .HasOne(p => p.SdIndex)
            //    .WithMany(b => b.TeamRankings)
            //    .HasForeignKey(p => p.SdIndex);



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
        public DbSet<SeasonRanking> SeasonRanking { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<SdIndex> SdIndex { get; set; }
        public DbSet<TeamRanking> TeamRanking { get; set; }
        public DbSet<WeekPeriod> WeekPeriod { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}