using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<SeasonRanking> GetSeasonRankings(long seasonLeagueId)
        {
            return _appDbContext.SeasonRanking
                .Where(s => s.SeasonLeagueId.Equals(seasonLeagueId));
        }
    }
}