using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Region
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
    }
}
