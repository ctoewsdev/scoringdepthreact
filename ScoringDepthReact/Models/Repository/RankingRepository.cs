using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ranking> GetRankings()
        {
            return _appDbContext.Ranking;
        }
    }
}

