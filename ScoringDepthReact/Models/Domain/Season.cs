using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class Season
    {
        public long SeasonId { get; set; }

        public long YearId { get; set; }
        public Year Year { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonLeague> SeasonLeagues { get; set; }

    }
}
