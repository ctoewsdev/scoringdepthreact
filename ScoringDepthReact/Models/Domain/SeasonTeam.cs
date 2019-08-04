namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    /// Linking SeasonLeague and Team
    /// </summary>
    public class SeasonTeam
    {
        public long SeasonTeamId { get; set; }

        public long SeasonLeagueId { get; set; }
        public SeasonLeague SeasonLeague { get; set; }

        public long TeamId { get; set; }
        public Team Team { get; set; }
    }
}