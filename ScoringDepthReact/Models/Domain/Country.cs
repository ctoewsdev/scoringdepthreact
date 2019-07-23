using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Models.Domain
{
    public class Country
    {
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<SeasonLeague> SeasonLeague { get; set; }

    }
}
