using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }
    }
}
