using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class SeasonTeam
    {
      
        public long SeasonTeamId { get; set; }

     
        public long SeasonLeagueId { get; set; }
        public SeasonLeague SeasonLeague { get; set; }

    
        public long TeamId { get; set; }
        public Team Team { get; set; }



    }
}
