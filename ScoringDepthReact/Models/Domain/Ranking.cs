using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Ranking
    {
        public long RankingId { get; set; }
        public int Period { get; set; }
        public double Sdi { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonRanking> SeasonRankingRefIds { get; set; }
    }
}
