using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class WeekPeriodRepository : IWeekPeriodRepository
    {
        private readonly AppDbContext _appDbContext;

        public WeekPeriodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<WeekPeriod> GetWeekPeriods()
        {
            return _appDbContext.WeekPeriod;
        }
    }
}