using System.Collections.Generic;
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

        public IEnumerable<Year> GetYears()
        {
            return _appDbContext.Year;
        }
    }
}