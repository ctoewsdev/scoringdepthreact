using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class WeekPeriod
    {
        public long WeekPeriodId { get; set; }
        public string Name { get; set; }
    
        //collection navigation to linking class
       // public ICollection<SeasonRanking> SeasonRankings { get; set; }
    }
}