using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface IWeekPeriodRepository
    {
        IEnumerable<WeekPeriod> GetWeekPeriods();
    }
}
