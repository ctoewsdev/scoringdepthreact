using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class Region
    {
        public long RegionId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        //foreign key to get Country data
        public long CountryId { get; set; }
        public Country Country { get; set; }

        //collection navigation to linking class
        public ICollection<Season> Seasons { get; set; }
    }
}
