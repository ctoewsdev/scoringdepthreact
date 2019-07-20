using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class LeagueRepository : ILeagueRepository
    {

        private readonly AppDbContext _appDbContext;

        public LeagueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<League> GetAllLeagues()
        {
            return _appDbContext.League;
        }

        public League GetLeagueById(int leagueId)
        {
            return _appDbContext.League.FirstOrDefault(l => l.Id == leagueId);
        }
    }
}

