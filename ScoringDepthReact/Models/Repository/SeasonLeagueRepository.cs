using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonLeagueRepository : ISeasonLeagueRepository
    {

        private readonly AppDbContext _appDbContext;

        public SeasonLeagueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SeasonLeague> GetSeasonLeagues()
        {
            return _appDbContext.SeasonLeague;
        }

        //public Year GetYearById(int yearId)
        //{
        //    return _appDbContext.Year.FirstOrDefault(s => s.YearId == yearId);
        //}
    }
}

