using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class Ranking
    {
        public long RankingId { get; set; }
        public int Period { get; set; }
        public double SDI { get; set; }

        //collection navigation to linking class
        public ICollection<TeamRanking> TeamRankings { get; set; }
    }
}