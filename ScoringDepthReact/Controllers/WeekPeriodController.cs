using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class WeekPeriodController : Controller
    {
        private readonly IWeekPeriodRepository _weekPeriodRepository;

        public WeekPeriodController(IWeekPeriodRepository weekPeriodRepository)
        {
            _weekPeriodRepository = weekPeriodRepository;
        }

        [HttpGet]
        public List<WeekPeriod> GetYears()
        {
            return _weekPeriodRepository.GetWeekPeriods().ToList();
        }
    }
}
