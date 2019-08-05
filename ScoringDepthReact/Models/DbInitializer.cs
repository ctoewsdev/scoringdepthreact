using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Country.Any())
            {
                //Sample test data

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
                var sbc1 = (new Season { YearId = y18.YearId, RegionId = canBc.RegionId });
                var sab2 = (new Season { YearId = y18.YearId, RegionId = canAb.RegionId });
                var sbc3 = (new Season { YearId = y19.YearId, RegionId = canBc.RegionId });
                var sab4 = (new Season { YearId = y19.YearId, RegionId = canAb.RegionId });
                var ssk5 = (new Season { YearId = y19.YearId, RegionId = canSk.RegionId });
                var sus6 = (new Season { YearId = y19.YearId, RegionId = usWest.RegionId });
                seasons.Add(sbc1);
                seasons.Add(sab2);
                seasons.Add(sbc3);
                seasons.Add(sab4);
                seasons.Add(ssk5);
                seasons.Add(sus6);
                seasons.ForEach(x => context.Season.Add(x));
                context.SaveChanges();

                //Leagues
                var leagues = new List<League>();
                var bchl = (new League
                { Name = "British Columbia Junior Hockey League", Code = "BCHL", ImageUrl = "bchl.jpg" });
                var vijhl = (new League
                { Name = "Vancouver Island Junior Hockey League", Code = "VIJHL", ImageUrl = "vijhl.jpg" });
                var kijhl = (new League
                { Name = "Kootney International Junior Hockey League", Code = "KIJHL", ImageUrl = "kijhl.jpg" });
                var pjhl = (new League { Name = "Pacific Junior Hockey League", Code = "PJHL", ImageUrl = "pjhl.jpg" });
                var ajhl = (new League { Name = "Alberta Junior Hockey League", Code = "AJHL", ImageUrl = "ajhl.jpg" });
                var wshl = (new League { Name = "Western States Hockey League", Code = "WSHL", ImageUrl = "wshl.jpg" });
                leagues.Add(bchl);
                leagues.Add(vijhl);
                leagues.Add(kijhl);
                leagues.Add(pjhl);
                leagues.Add(ajhl);
                leagues.Add(wshl);
                leagues.ForEach(x => context.League.Add(x));
                context.SaveChanges();

                //SeasonLeague
                var seasonLeagues = new List<SeasonLeague>();
                var ls1 = (new SeasonLeague { SeasonId = sbc1.SeasonId, LeagueId = bchl.LeagueId });

                var ls2 = (new SeasonLeague { SeasonId = sbc1.SeasonId, LeagueId = pjhl.LeagueId });
                var ls3 = (new SeasonLeague { SeasonId = sbc1.SeasonId, LeagueId = bchl.LeagueId });
                var ls4 = (new SeasonLeague { SeasonId = sbc3.SeasonId, LeagueId = pjhl.LeagueId });
                var ls5 = (new SeasonLeague { SeasonId = sab4.SeasonId, LeagueId = ajhl.LeagueId });
                var ls6 = (new SeasonLeague { SeasonId = sus6.SeasonId, LeagueId = wshl.LeagueId });
                var ls7 = (new SeasonLeague { SeasonId = sbc3.SeasonId, LeagueId = bchl.LeagueId });
                var ls8 = (new SeasonLeague { SeasonId = sbc3.SeasonId, LeagueId = vijhl.LeagueId });
                var ls9 = (new SeasonLeague { SeasonId = sbc3.SeasonId, LeagueId = kijhl.LeagueId });
                seasonLeagues.Add(ls1);
                seasonLeagues.Add(ls2);
                seasonLeagues.Add(ls3);
                seasonLeagues.Add(ls4);
                seasonLeagues.Add(ls5);
                seasonLeagues.Add(ls6);
                seasonLeagues.Add(ls7);
                seasonLeagues.Add(ls8);
                seasonLeagues.Add(ls9);
                seasonLeagues.ForEach(x => context.SeasonLeague.Add(x));
                context.SaveChanges();

                //Week Period
                var weekPeriods = new List<WeekPeriod>();
                var wp1 = (new WeekPeriod { Name = "201840" });
                var wp2 = (new WeekPeriod { Name = "201841" });
                var wp3 = (new WeekPeriod { Name = "201842" });
                var wp4 = (new WeekPeriod { Name = "201843" });
                var wp5 = (new WeekPeriod { Name = "201844" });
                var wp6 = (new WeekPeriod { Name = "201845" });
                var wp7 = (new WeekPeriod { Name = "201846" });
                var wp8 = (new WeekPeriod { Name = "201847" });
                weekPeriods.Add(wp1);
                weekPeriods.Add(wp2);
                weekPeriods.Add(wp3);
                weekPeriods.Add(wp4);
                weekPeriods.Add(wp5);
                weekPeriods.Add(wp6);
                weekPeriods.Add(wp7);
                weekPeriods.Add(wp8);
                weekPeriods.ForEach(x => context.WeekPeriod.Add(x));
                context.SaveChanges();

                //SeasonRanking
                var seasonRankings = new List<SeasonRanking>();
                var sr1 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp1.WeekPeriodId });
                var sr2 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp2.WeekPeriodId });
                var sr3 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp3.WeekPeriodId });
                var sr4 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp4.WeekPeriodId });
                var sr5 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp5.WeekPeriodId });
                var sr6 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp6.WeekPeriodId });
                var sr7 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp7.WeekPeriodId });
                var sr8 = (new SeasonRanking { SeasonLeagueId = ls2.SeasonLeagueId, WeekPeriodId = wp8.WeekPeriodId });

                seasonRankings.Add(sr1);
                seasonRankings.Add(sr2);
                seasonRankings.Add(sr3);
                seasonRankings.Add(sr4);
                seasonRankings.Add(sr5);
                seasonRankings.Add(sr6);
                seasonRankings.Add(sr7);
                seasonRankings.Add(sr8);
                seasonRankings.ForEach(x => context.SeasonRanking.Add(x));
                context.SaveChanges();

                //Teams
                var teams = new List<Team>();
                var pilots = (new Team
                    { GeographyName = "Abbotsford", TeamName = "Pilots", ImageUrl = "pilots.jpg" });
                var trappers = (new Team { GeographyName = "Langley", TeamName = "Trappers", ImageUrl = "trappers.jpg" });
                var kodiaks = (new Team { GeographyName = "Aldergrove", TeamName = "Kodiaks", ImageUrl = "kodiaks.jpg" });
                var icehawks = (new Team { GeographyName = "Delta", TeamName = "IceHawks", ImageUrl = "icehawks.jpg" });
                var cents = (new Team { GeographyName = "Merritt", TeamName = "Cents", ImageUrl = "cents.jpg" });
                var storm = (new Team { GeographyName = "Calgary", TeamName = "Storm", ImageUrl = "storm.jpg" });
                var blazers = (new Team { GeographyName = "Bellingham", TeamName = "Blazers", ImageUrl = "blazers.jpg" });
                teams.Add(pilots);
                teams.Add(trappers);
                teams.Add(kodiaks);
                teams.Add(icehawks);
                teams.Add(cents);
                teams.Add(storm);
                teams.Add(blazers);
                teams.ForEach(x => context.Team.Add(x));
                context.SaveChanges();

                //SdIndex
                var sdIndexes = new List<SdIndex>();
                var r1 = (new SdIndex { Index = 2.1 });
                var r2 = (new SdIndex { Index = 2.3 });
                var r3 = (new SdIndex { Index = 2.4 });
                var r4 = (new SdIndex { Index = 2.7 });
                var r5 = (new SdIndex { Index = 2.95 });
                var r6 = (new SdIndex { Index = 3.3 });
                var r7 = (new SdIndex { Index = 3.8 });
                var r8 = (new SdIndex { Index = 3.9 });
                var r9 = (new SdIndex { Index = 4.3 });
                var r10 = (new SdIndex { Index = 4.4 });
                var r11 = (new SdIndex { Index = 4.2 });
                var r12 = (new SdIndex { Index = 4.0 });
                var r13 = (new SdIndex { Index = 3.85 });
                var r14 = (new SdIndex { Index = 3.55 });
                var r15 = (new SdIndex { Index = 3.2 });
                var r16 = (new SdIndex { Index = 3.1 });
                var r17 = (new SdIndex { Index = 3.8 });
                var r18 = (new SdIndex { Index = 4.1 });
                var r19 = (new SdIndex { Index = 4.05 });
                var r20 = (new SdIndex { Index = 4.45 });
                var r21 = (new SdIndex { Index = 5 });
                var r22 = (new SdIndex { Index = 5.1 });
                var r23 = (new SdIndex { Index = 4.6 });
                var r24 = (new SdIndex { Index = 4.2 });
                var r25 = (new SdIndex { Index = 6.1 });
                var r26 = (new SdIndex { Index = 6.01 });
                var r27 = (new SdIndex { Index = 5.98 });
                var r28 = (new SdIndex { Index = 4.3 });
                var r29 = (new SdIndex { Index = 4.1 });
                var r30 = (new SdIndex { Index = 3.7 });
                var r31 = (new SdIndex { Index = 2.8 });
                var r32 = (new SdIndex { Index = 3.1 });
                sdIndexes.Add(r1);
                sdIndexes.Add(r2);
                sdIndexes.Add(r3);
                sdIndexes.Add(r4);
                sdIndexes.Add(r5);
                sdIndexes.Add(r6);
                sdIndexes.Add(r7);
                sdIndexes.Add(r8);
                sdIndexes.Add(r9);
                sdIndexes.Add(r10);
                sdIndexes.Add(r11);
                sdIndexes.Add(r12);
                sdIndexes.Add(r13);
                sdIndexes.Add(r14);
                sdIndexes.Add(r15);
                sdIndexes.Add(r16);
                sdIndexes.Add(r17);
                sdIndexes.Add(r18);
                sdIndexes.Add(r19);
                sdIndexes.Add(r20);
                sdIndexes.Add(r21);
                sdIndexes.Add(r22);
                sdIndexes.Add(r23);
                sdIndexes.Add(r24);
                sdIndexes.Add(r25);
                sdIndexes.Add(r26);
                sdIndexes.Add(r27);
                sdIndexes.Add(r28);
                sdIndexes.Add(r29);
                sdIndexes.Add(r30);
                sdIndexes.Add(r31);
                sdIndexes.Add(r32);
                sdIndexes.ForEach(x => context.SdIndex.Add(x));
                context.SaveChanges();

                //TeamRanking
                var teamRankings = new List<TeamRanking>();
                var tr1= (new TeamRanking { SeasonRankingId = sr1.SeasonRankingId, SdIndexId = r1.SdIndexId, TeamId = kodiaks.TeamId });
                var tr2 = (new TeamRanking { SeasonRankingId = sr2.SeasonRankingId, SdIndexId = r2.SdIndexId, TeamId = kodiaks.TeamId });
                var tr3 = (new TeamRanking { SeasonRankingId = sr3.SeasonRankingId, SdIndexId = r3.SdIndexId, TeamId = kodiaks.TeamId });
                var tr4 = (new TeamRanking { SeasonRankingId = sr4.SeasonRankingId, SdIndexId = r4.SdIndexId, TeamId = kodiaks.TeamId });
                var tr5 = (new TeamRanking { SeasonRankingId = sr5.SeasonRankingId, SdIndexId = r5.SdIndexId, TeamId = kodiaks.TeamId });
                var tr6 = (new TeamRanking { SeasonRankingId = sr6.SeasonRankingId, SdIndexId = r6.SdIndexId, TeamId = kodiaks.TeamId });
                var tr7 = (new TeamRanking { SeasonRankingId = sr7.SeasonRankingId, SdIndexId = r7.SdIndexId, TeamId = kodiaks.TeamId });
                var tr8 = (new TeamRanking { SeasonRankingId = sr8.SeasonRankingId, SdIndexId = r8.SdIndexId, TeamId = kodiaks.TeamId });
                var tr9 = (new TeamRanking { SeasonRankingId = sr1.SeasonRankingId, SdIndexId = r9.SdIndexId, TeamId = pilots.TeamId });
                var tr10 = (new TeamRanking { SeasonRankingId = sr2.SeasonRankingId, SdIndexId = r10.SdIndexId, TeamId = pilots.TeamId });
                var tr11 = (new TeamRanking { SeasonRankingId = sr3.SeasonRankingId, SdIndexId = r11.SdIndexId, TeamId = pilots.TeamId });
                var tr12 = (new TeamRanking { SeasonRankingId = sr4.SeasonRankingId, SdIndexId = r12.SdIndexId, TeamId = pilots.TeamId });
                var tr13 = (new TeamRanking { SeasonRankingId = sr5.SeasonRankingId, SdIndexId = r13.SdIndexId, TeamId = pilots.TeamId });
                var tr14 = (new TeamRanking { SeasonRankingId = sr6.SeasonRankingId, SdIndexId = r14.SdIndexId, TeamId = pilots.TeamId });
                var tr15 = (new TeamRanking { SeasonRankingId = sr7.SeasonRankingId, SdIndexId = r15.SdIndexId, TeamId = pilots.TeamId });
                var tr16 = (new TeamRanking { SeasonRankingId = sr8.SeasonRankingId, SdIndexId = r16.SdIndexId, TeamId = pilots.TeamId });
                var tr17 = (new TeamRanking { SeasonRankingId = sr1.SeasonRankingId, SdIndexId = r17.SdIndexId, TeamId = trappers.TeamId });
                var tr18 = (new TeamRanking { SeasonRankingId = sr2.SeasonRankingId, SdIndexId = r18.SdIndexId, TeamId = trappers.TeamId });
                var tr19 = (new TeamRanking { SeasonRankingId = sr3.SeasonRankingId, SdIndexId = r19.SdIndexId, TeamId = trappers.TeamId });
                var tr20 = (new TeamRanking { SeasonRankingId = sr4.SeasonRankingId, SdIndexId = r20.SdIndexId, TeamId = trappers.TeamId });
                var tr21 = (new TeamRanking { SeasonRankingId = sr5.SeasonRankingId, SdIndexId = r21.SdIndexId, TeamId = trappers.TeamId });
                var tr22 = (new TeamRanking { SeasonRankingId = sr6.SeasonRankingId, SdIndexId = r22.SdIndexId, TeamId = trappers.TeamId });
                var tr23 = (new TeamRanking { SeasonRankingId = sr7.SeasonRankingId, SdIndexId = r23.SdIndexId, TeamId = trappers.TeamId });
                var tr24 = (new TeamRanking { SeasonRankingId = sr8.SeasonRankingId, SdIndexId = r24.SdIndexId, TeamId = trappers.TeamId });
                var tr25 = (new TeamRanking { SeasonRankingId = sr1.SeasonRankingId, SdIndexId = r25.SdIndexId, TeamId = icehawks.TeamId });
                var tr26 = (new TeamRanking { SeasonRankingId = sr2.SeasonRankingId, SdIndexId = r26.SdIndexId, TeamId = icehawks.TeamId });
                var tr27 = (new TeamRanking { SeasonRankingId = sr3.SeasonRankingId, SdIndexId = r27.SdIndexId, TeamId = icehawks.TeamId });
                var tr28 = (new TeamRanking { SeasonRankingId = sr4.SeasonRankingId, SdIndexId = r28.SdIndexId, TeamId = icehawks.TeamId });
                var tr29 = (new TeamRanking { SeasonRankingId = sr5.SeasonRankingId, SdIndexId = r29.SdIndexId, TeamId = icehawks.TeamId });
                var tr30 = (new TeamRanking { SeasonRankingId = sr6.SeasonRankingId, SdIndexId = r30.SdIndexId, TeamId = icehawks.TeamId });
                var tr31 = (new TeamRanking { SeasonRankingId = sr7.SeasonRankingId, SdIndexId = r31.SdIndexId, TeamId = icehawks.TeamId });
                var tr32 = (new TeamRanking { SeasonRankingId = sr8.SeasonRankingId, SdIndexId = r32.SdIndexId, TeamId = icehawks.TeamId });

                teamRankings.Add(tr1);
                teamRankings.Add(tr2);
                teamRankings.Add(tr3);
                teamRankings.Add(tr4);
                teamRankings.Add(tr5);
                teamRankings.Add(tr6);
                teamRankings.Add(tr7);
                teamRankings.Add(tr8);
                teamRankings.Add(tr9);
                teamRankings.Add(tr10);
                teamRankings.Add(tr11);
                teamRankings.Add(tr12);
                teamRankings.Add(tr13);
                teamRankings.Add(tr14);
                teamRankings.Add(tr15);
                teamRankings.Add(tr16);
                teamRankings.Add(tr17);
                teamRankings.Add(tr18);
                teamRankings.Add(tr19);
                teamRankings.Add(tr20);
                teamRankings.Add(tr21);
                teamRankings.Add(tr22);
                teamRankings.Add(tr23);
                teamRankings.Add(tr24);
                teamRankings.Add(tr25);
                teamRankings.Add(tr26);
                teamRankings.Add(tr27);
                teamRankings.Add(tr28);
                teamRankings.Add(tr29);
                teamRankings.Add(tr30);
                teamRankings.Add(tr31);
                teamRankings.Add(tr32);
                teamRankings.ForEach(x => context.TeamRanking.Add(x));
                context.SaveChanges();
            }
        }
    }
}
