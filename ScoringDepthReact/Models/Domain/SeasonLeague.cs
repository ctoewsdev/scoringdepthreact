using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    ///Linking Season and League
    /// </summary>
    public class SeasonLeague
    {
        public long SeasonLeagueId { get; set; }

        public long SeasonId { get; set; }
        public Season Season { get; set; }

        public long LeagueId { get; set; }
        public League League { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonTeam> TeamSeasons { get; set; }
    }
}
