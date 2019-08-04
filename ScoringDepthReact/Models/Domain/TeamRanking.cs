using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class TeamRanking
    {     
        public long TeamRankingId { get; set; }
 
        public long SeasonTeamId { get; set; }
        public SeasonTeam SeasonTeam { get; set; }

        public long RankingId { get; set; }
        public Ranking Ranking { get; set; }
    }
}
