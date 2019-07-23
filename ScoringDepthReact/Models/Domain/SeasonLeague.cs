using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ScoringDepthReact.Models.Domain
{
    public class SeasonLeague
    {
        public long SeasonId { get; set; }
        public Season Season { get; set; }

        public long CountryId { get; set; }
        public Country Country { get; set; }

        public long RegionId { get; set; }
        public Region Region { get; set; }

        public long LeagueId { get; set; }
        public League League { get; set; }

        public long TeamId { get; set; }
        public Team Team { get; set; }

        public long WeekRankingId { get; set; }
        public WeekRanking WeekRanking { get; set; }
    }
}
