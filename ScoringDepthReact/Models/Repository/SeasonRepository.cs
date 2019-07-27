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
        public IEnumerable<Season> GetSeasons()
        {
            return _appDbContext.Season;
        }

        //public Year GetYearById(int yearId)
        //{
        //    return _appDbContext.Year.FirstOrDefault(s => s.YearId == yearId);
        //}
    }
}

