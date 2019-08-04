using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class SeasonLeague
    {
        public long SeasonLeagueId { get; set; }

        public long SeasonId { get; set; }
        public Season Season { get; set; }
 
        public long LeagueId { get; set; }
        public League League { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonTeam> TeamSeasons { get; set; }


    }
}
