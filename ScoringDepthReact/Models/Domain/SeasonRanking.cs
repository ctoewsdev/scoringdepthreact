using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    /// Linking SeasonLeague and WeekPeriod
    /// </summary>
    public class SeasonRanking
    {
        public long SeasonRankingId { get; set; }

        public long SeasonLeagueId { get; set; }
        public SeasonLeague SeasonLeague { get; set; }

        public long WeekPeriodId { get; set; }
        public WeekPeriod WeekPeriod { get; set; }

        public ICollection<TeamRanking> TeamRankings { get; set; }
    }
}