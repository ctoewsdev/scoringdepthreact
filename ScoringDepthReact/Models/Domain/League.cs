using System.Collections.Generic;

namespace ScoringDepthReact.Models.Domain
{
    public class League
    {
        public long LeagueId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImageUrl { get; set; }

        //collection navigation to linking class
        public ICollection<SeasonLeague> SeasonLeague { get; set; }
    }
}