using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonRepository : ISeasonRepository
    {

        private readonly AppDbContext _appDbContext;

        public SeasonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Season> GetAllSeasons()
        {
            return _appDbContext.Season;
        }

        public Season GetSeasonById(int seasonId)
        {
            return _appDbContext.Season.FirstOrDefault(s => s.SeasonId == seasonId);
        }
    }
}

