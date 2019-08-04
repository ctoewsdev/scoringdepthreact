using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class YearController : Controller
    {
        private readonly IYearRepository _yearRepository;

        public YearController(IYearRepository yearRepository)
        {
            _yearRepository = yearRepository;
        }

        [HttpGet]
        public List<Year> GetYears()
        {
            var years = _yearRepository.GetYears().ToList();
            return years;
        }
    }
}
