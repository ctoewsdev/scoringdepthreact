using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonTeamRepository : ISeasonTeamRepository
    {
        private readonly AppDbContext _appDbContext;

        public SeasonTeamRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SeasonTeam> GetSeasonTeams()
        {
            return _appDbContext.SeasonTeam;
        }
    }
}