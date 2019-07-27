using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class LeagueSeason
    {
        public long LeagueSeasonId { get; set; }

        public long YearRegionId { get; set; }
        public Season YearRegion { get; set; }
 
        public long LeagueId { get; set; }
        public League League { get; set; }

        //collection navigation to linking class
        public ICollection<TeamSeason> TeamSeasons { get; set; }


    }
}
