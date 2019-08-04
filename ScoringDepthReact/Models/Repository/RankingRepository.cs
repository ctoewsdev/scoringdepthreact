using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class RankingRepository : IRankingRepository
    {
        private readonly AppDbContext _appDbContext;

        public RankingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ranking> GetRankings()
        {
            return _appDbContext.Ranking;
        }
    }
}