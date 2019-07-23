using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class WeekRanking
    {
        public long WeekRankingId { get; set; }
        public int Week { get; set; }
        public double Sdi { get; set; }

        public ICollection<SeasonLeague> SeasonLeague { get; set; }
    }
}
