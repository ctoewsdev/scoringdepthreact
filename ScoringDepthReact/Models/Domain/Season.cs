using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Season
    {
        public long Id { get; set; }
        public int YearStart { get; set; }
        public string Name { get; set; }
    }
}
