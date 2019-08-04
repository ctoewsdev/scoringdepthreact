using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeamRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Team> GetTeams()
        {
            return _appDbContext.Team;
        }
    }
}