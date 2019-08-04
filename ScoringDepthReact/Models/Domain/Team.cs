using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ScoringDepthReact.Models.Domain
{
    public class Team
    {
        public long TeamId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonTeam> SeasonTeams { get; set; }
    }
}
