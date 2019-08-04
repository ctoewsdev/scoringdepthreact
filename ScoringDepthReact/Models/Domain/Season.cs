using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    /// Linking Year and Region
    /// </summary>
    public class Season
    {
        public long SeasonId { get; set; }

        public long YearId { get; set; }
        public Year Year { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonLeague> SeasonLeagues { get; set; }
    }
}