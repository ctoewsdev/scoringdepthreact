using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class Team
    {
        public long TeamId { get; set; }
        public string GeographyName { get; set; }
        public string TeamName { get; set; }
        public string ImageUrl { get; set; }

        //collection navigation to linking class
        public ICollection<TeamRanking> TeamRankings { get; set; }
    }
}
