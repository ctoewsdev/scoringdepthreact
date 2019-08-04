using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonLeagueRepository : ISeasonLeagueRepository
    {
        private readonly AppDbContext _appDbContext;

        public SeasonLeagueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SeasonLeague> GetSeasonLeagues()
        {
            return _appDbContext.SeasonLeague;
        }
    }
}