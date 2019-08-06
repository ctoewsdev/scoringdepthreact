using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class TeamRankingRepository : ITeamRankingRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeamRankingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<TeamRanking> GetTeamRankings()
        {
            return _appDbContext.TeamRanking;
        }
    }
}