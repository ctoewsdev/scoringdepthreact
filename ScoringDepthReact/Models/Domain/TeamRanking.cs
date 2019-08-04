namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    /// Linking SeasonTeam and Ranking
    /// </summary>
    public class TeamRanking
    {
        public long TeamRankingId { get; set; }

        public long SeasonTeamId { get; set; }
        public SeasonTeam SeasonTeam { get; set; }

        public long RankingId { get; set; }
        public Ranking Ranking { get; set; }
    }
}
