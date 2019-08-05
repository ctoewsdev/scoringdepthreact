using System.ComponentModel.DataAnnotations.Schema;

namespace ScoringDepthReact.Models.Domain
{
    /// <summary>
    /// Linking SeasonRanking, Team and SdIndex
    /// </summary>
    public class TeamRanking
    {
        public long TeamRankingId { get; set; }

        public long SeasonRankingId { get; set; }
        public SeasonRanking SeasonRanking { get; set; }

        public long TeamId { get; set; }
        public Team Team { get; set; }

    
        public long SdIndexId { get; set; }
        public SdIndex SdIndex { get; set; }
    }
}
