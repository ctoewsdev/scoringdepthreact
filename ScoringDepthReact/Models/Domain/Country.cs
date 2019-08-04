using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class Country
    {
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }

        //collection navigation to linking class
        public ICollection<Region> RegionRefIds { get; set; }
    }
}
