using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Season.Any())

            {
                //Id's added automatically

                //Seasons
                var seasons = new List<Season>();
                var s17 = (new Season {YearStart = 2017, Name = "2017-18"});
                var s18 = (new Season { YearStart = 2018, Name = "2018-19" });
                var s19 = (new Season { YearStart = 2019, Name = "2019-20" });
                var s20 = (new Season { YearStart = 2020, Name = "2020-21" });
                seasons.Add(s17);
                seasons.Add(s18);
                seasons.Add(s19);
                seasons.Add(s20);
                context.AddRange(seasons);

                //Countries
                var countries = new List<Country>();
                var can = (new Country {Name = "Canada", Code = "Can", ImageUrl = "canada.jpg"});
                var usa = (new Country { Name = "USA", Code ="US", ImageUrl = "usa.jpg" });
                countries.Add(can);
                countries.Add(usa);
                context.AddRange(countries);


                //Regions
                var regions = new List<Region>();
                var canBc = (new Region {Name = "British Columbia", Code = "BC"});
                var canAb = (new Region { Name = "Alberta", Code = "AB" });
                var canSk = (new Region { Name = "Saskatchewan", Code = "SK" });
                var usWest = (new Region { Name = "West", Code = "W" });
                regions.Add(canBc);
                regions.Add(canAb);
                regions.Add(canSk);
                regions.Add(usWest);
                context.AddRange(regions);

                //Leagues
                var leagues = new List<League>();
                var bcbchl = (new League
                    {Name = "British Columbia Junior Hockey League", Code = "BCHL", ImageUrl = "bchl.jpg"});
                var bcpjhl = (new League { Name = "Pacific Junior Hockey League", Code ="PJHL", ImageUrl = "pjhl.jpg" });
                leagues.Add(bcbchl);
                leagues.Add(bcpjhl);
                context.AddRange(leagues);

                //Teams
                var teams = new List<Team>();
                var pilots1 = (new Team
                { Name = "Abbotsford Pilots", Code = "Pilots", ImageUrl = "pilots1.jpg" });
                var trappers1 = (new Team { Name = "Pacific Junior Hockey League", Code = "PJHL", ImageUrl = "trappers1.jpg" });
                teams.Add(pilots1);
                teams.Add(trappers1);
                context.AddRange(teams);

                //WeekRanking
                var weekRankings = new List<WeekRanking>();
                var s18PilotsWk1 = (new WeekRanking { Week = 1, Sdi = 4.302 });
                var s18PilotsWk2 = (new WeekRanking { Week = 2, Sdi = 4.112 });
                var s18TrappersWk1 = (new WeekRanking { Week = 1, Sdi = 3.918 });
                var s18TrappersWk2 = (new WeekRanking { Week = 2, Sdi = 4.249 });
                weekRankings.Add(s18PilotsWk1);
                weekRankings.Add(s18PilotsWk2);
                weekRankings.Add(s18TrappersWk1);
                weekRankings.Add(s18TrappersWk2);
                context.AddRange(weekRankings);



                //SeasonLeague
                var seasonLeagues = new List<SeasonLeague>();
                var s18Sl1 = (new SeasonLeague { SeasonId = s18.SeasonId, CountryId = can.CountryId, RegionId = canBc.RegionId, LeagueId = bcpjhl.LeagueId, TeamId = pilots1.TeamId, WeekRankingId = s18PilotsWk1.WeekRankingId });
                //var s18Sl2 = (new SeasonLeague { Season = s18, Country = can, Region = canBc, League = bcpjhl, Team = pilots1, WeekRanking = s18PilotsWk2 });
                //var s18Sl3 = (new SeasonLeague { Season = s18, Country = can, Region = canBc, League = bcpjhl, Team = trappers1, WeekRanking = s18TrappersWk1 });
                //var s18Sl4 = (new SeasonLeague { Season = s18, Country = can, Region = canBc, League = bcpjhl, Team = trappers1, WeekRanking = s18TrappersWk2 });

                seasonLeagues.Add(s18Sl1);
                //seasonLeagues.Add(s18Sl2);
                //seasonLeagues.Add(s18Sl3);
                //seasonLeagues.Add(s18Sl4);
                context.AddRange(seasonLeagues);

                context.SaveChanges();


            }
        }
    }
}
