using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Region
    {
        public long RegionId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

      
        public long CountryId { get; set; }
        public Country Country { get; set; }

        //collection navigation to linking class
        public ICollection<Season> Seasons { get; set; }

    }
}
