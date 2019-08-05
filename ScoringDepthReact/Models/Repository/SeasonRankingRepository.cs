using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonRankingRepository : ISeasonRankingRepository
    {
        private readonly AppDbContext _appDbContext;

        public SeasonRankingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SeasonRanking> GetSeasonRankings()
        {
            return _appDbContext.SeasonRanking;
        }
    }
}