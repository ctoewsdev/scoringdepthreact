using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class SeasonRanking
    {
        
        public long SeasonRankingId { get; set; }

    
        public long TeamSeasonId { get; set; }
        public TeamSeason TeamSeason { get; set; }

  
        public long RankingId { get; set; }
        public Ranking Ranking { get; set; }




    }
}
