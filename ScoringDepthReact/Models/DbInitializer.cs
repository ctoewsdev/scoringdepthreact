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
            if (!context.Country.Any())
            {
            //Id's added automatically

            //countries
            var countries = new List<Country>();
            var can = (new Country { Name = "Canada", Code = "Can", ImageUrl = "canada.jpg" });
            var usa = (new Country { Name = "USA", Code = "US", ImageUrl = "usa.jpg" });
            countries.Add(can);
            countries.Add(usa);
            countries.ForEach(x => context.Country.Add(x));
            context.SaveChanges();

            //Regions
            var regions = new List<Region>();
            var canBc = (new Region { Name = "British Columbia", Code = "BC", CountryId = can.CountryId });
            var canAb = (new Region { Name = "Alberta", Code = "AB", CountryId = can.CountryId });
            var canSk = (new Region { Name = "Saskatchewan", Code = "SK", CountryId = can.CountryId });
            var usWest = (new Region { Name = "West", Code = "W", CountryId = usa.CountryId });
            regions.Add(canBc);
            regions.Add(canAb);
            regions.Add(canSk);
            regions.Add(usWest);
            regions.ForEach(x => context.Region.Add(x));
            context.SaveChanges();

            //Years
            var years = new List<Year>();
            var y16 = (new Year { YearStart = 2016, Name = "2016-17" });
            var y17 = (new Year { YearStart = 2017, Name = "2017-18" });
            var y18 = (new Year { YearStart = 2018, Name = "2018-19" });
            var y19 = (new Year { YearStart = 2019, Name = "2019-20" });
            years.Add(y17);
            years.Add(y18);
            years.Add(y19);
            years.Add(y16);
            years.ForEach(x => context.Year.Add(x));
            context.SaveChanges();

            //YearRegion
            var seasons = new List<Season>();
            var s1 = (new Season { YearId = y18.YearId, RegionId = canBc.RegionId });
            var s2 = (new Season { YearId = y18.YearId, RegionId = canAb.RegionId });
            var s3 = (new Season { YearId = y19.YearId, RegionId = canBc.RegionId });
            var s4 = (new Season { YearId = y19.YearId, RegionId = canAb.RegionId });
            var s5 = (new Season { YearId = y19.YearId, RegionId = usWest.RegionId });
            seasons.Add(s1);
            seasons.Add(s2);
            seasons.Add(s3);
            seasons.Add(s4);
            seasons.Add(s5);
            seasons.ForEach(x => context.Season.Add(x));
            context.SaveChanges();

            //Leagues
            var leagues = new List<League>();
            var bchl = (new League
            { Name = "British Columbia Junior Hockey League", Code = "BCHL", ImageUrl = "bchl.jpg" });
            var pjhl = (new League { Name = "Pacific Junior Hockey League", Code = "PJHL", ImageUrl = "pjhl.jpg" });
            var ajhl = (new League { Name = "Alberta Junior Hockey League", Code = "AJHL", ImageUrl = "ajhl.jpg" });
            var wshl = (new League { Name = "Western States Hockey League", Code = "WSHL", ImageUrl = "wshl.jpg" });
            leagues.Add(bchl);
            leagues.Add(pjhl);
            leagues.Add(ajhl);
            leagues.Add(wshl);
            leagues.ForEach(x => context.League.Add(x));
            context.SaveChanges();

            //LeagueSeason
            var leagueSeasons = new List<LeagueSeason>();
            var ls1 = (new LeagueSeason { YearRegionId = s1.SeasonId, LeagueId = bchl.LeagueId });

            var ls2 = (new LeagueSeason { YearRegionId = s1.SeasonId, LeagueId = pjhl.LeagueId });
            var ls3 = (new LeagueSeason { YearRegionId = s2.SeasonId, LeagueId = bchl.LeagueId });
            var ls4 = (new LeagueSeason { YearRegionId = s2.SeasonId, LeagueId = pjhl.LeagueId });
            var ls5 = (new LeagueSeason { YearRegionId = s3.SeasonId, LeagueId = ajhl.LeagueId });
            var ls6 = (new LeagueSeason { YearRegionId = s4.SeasonId, LeagueId = wshl.LeagueId });
            leagueSeasons.Add(ls1);
            leagueSeasons.Add(ls2);
            leagueSeasons.Add(ls3);
            leagueSeasons.Add(ls4);
            leagueSeasons.Add(ls5);
            leagueSeasons.Add(ls6);
            leagueSeasons.ForEach(x => context.LeagueSeason.Add(x));
            context.SaveChanges();

            //Teams
            var teams = new List<Team>();
            var pilots = (new Team
            { Name = "Abbotsford Pilots", Code = "Pilots", ImageUrl = "pilots.jpg" });
            var trappers = (new Team { Name = "Langley Trappers", Code = "Trappers", ImageUrl = "trappers.jpg" });
            var cents = (new Team { Name = "Merritt Centenials", Code = "Cents", ImageUrl = "trappers.jpg" });
            var storm = (new Team { Name = "Calgary Storm", Code = "Storm", ImageUrl = "storm.jpg" });
            var blazers = (new Team { Name = "Bellingham Blazers", Code = "Blazers", ImageUrl = "blazers.jpg" });
            teams.Add(pilots);
            teams.Add(trappers);
            teams.Add(cents);
            teams.Add(storm);
            teams.Add(blazers);
            teams.ForEach(x => context.Team.Add(x));
            context.SaveChanges();

            //TeamSeason
            var teamSeasons = new List<TeamSeason>();
            var ts1 = (new TeamSeason { LeagueSeason = ls3, LeagueSeasonId = ls3.LeagueSeasonId, TeamId = cents.TeamId });
            var ts2 = (new TeamSeason { LeagueSeasonId = ls2.LeagueSeasonId, TeamId = trappers.TeamId });
            var ts3 = (new TeamSeason { LeagueSeasonId = ls2.LeagueSeasonId, TeamId = pilots.TeamId });
            var ts4 = (new TeamSeason { LeagueSeasonId = ls4.LeagueSeasonId, TeamId = trappers.TeamId });
            var ts5 = (new TeamSeason { LeagueSeasonId = ls4.LeagueSeasonId, TeamId = pilots.TeamId });
            var ts6 = (new TeamSeason { LeagueSeasonId = ls5.LeagueSeasonId, TeamId = storm.TeamId });
            var ts7 = (new TeamSeason { LeagueSeasonId = ls6.LeagueSeasonId, TeamId = blazers.TeamId });
            teamSeasons.Add(ts1);
            teamSeasons.Add(ts2);
            teamSeasons.Add(ts3);
            teamSeasons.Add(ts4);
            teamSeasons.Add(ts5);
            teamSeasons.Add(ts6);
            teamSeasons.Add(ts7);
            teamSeasons.ForEach(x => context.TeamSeason.Add(x));
            context.SaveChanges();

            //Ranking
            var rankings = new List<Ranking>();
            var r1 = (new Ranking { Period = 1, Sdi = 4.302 });
            var r2 = (new Ranking { Period = 1, Sdi = 4.002 });
            var r3 = (new Ranking { Period = 2, Sdi = 3.918 });
            var r4 = (new Ranking { Period = 2, Sdi = 4.249 });
            var r5 = (new Ranking { Period = 3, Sdi = 3.621 });
            var r6 = (new Ranking { Period = 3, Sdi = 4.355 });
            var r7 = (new Ranking { Period = 4, Sdi = 3.337 });
            var r8 = (new Ranking { Period = 4, Sdi = 4.489 });
            rankings.Add(r1);
            rankings.Add(r2);
            rankings.Add(r3);
            rankings.Add(r4);
            rankings.Add(r5);
            rankings.Add(r6);
            rankings.Add(r7);
            rankings.ForEach(x => context.Ranking.Add(x));
            context.SaveChanges();

            //TeamRanking
            var seasonRankings = new List<SeasonRanking>();
            var sr1 = (new SeasonRanking { TeamSeasonId = ts4.TeamSeasonId, RankingId = r2.RankingId });
            var sr2 = (new SeasonRanking { TeamSeasonId = ts5.TeamSeasonId, RankingId = r1.RankingId });
            var sr3 = (new SeasonRanking { TeamSeasonId = ts4.TeamSeasonId, RankingId = r4.RankingId });
            var sr4 = (new SeasonRanking { TeamSeasonId = ts5.TeamSeasonId, RankingId = r3.RankingId });
            var sr5 = (new SeasonRanking { TeamSeasonId = ts4.TeamSeasonId, RankingId = r6.RankingId });
            var sr6 = (new SeasonRanking { TeamSeasonId = ts5.TeamSeasonId, RankingId = r5.RankingId });
            var sr7 = (new SeasonRanking { TeamSeasonId = ts4.TeamSeasonId, RankingId = r8.RankingId });
            var sr8 = (new SeasonRanking { TeamSeasonId = ts5.TeamSeasonId, RankingId = r7.RankingId });
            seasonRankings.Add(sr2);
            seasonRankings.Add(sr3);
            seasonRankings.Add(sr4);
            seasonRankings.Add(sr5);
            seasonRankings.Add(sr6);
            seasonRankings.Add(sr7);
            seasonRankings.Add(sr8);
            seasonRankings.ForEach(x => context.SeasonRanking.Add(x));
            context.SaveChanges();
            }
        }
    }
}
