using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class YearRepository : IYearRepository
    {

        private readonly AppDbContext _appDbContext;

        public YearRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Year> GetAllYears()
        {
            return _appDbContext.Year;
        }

        public Year GetYearById(int yearId)
        {
            return _appDbContext.Year.FirstOrDefault(s => s.YearId == yearId);
        }
    }
}

