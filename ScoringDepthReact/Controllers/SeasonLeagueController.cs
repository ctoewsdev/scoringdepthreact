using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class SeasonLeagueController : Controller
    {
        private readonly ISeasonLeagueRepository _seasonLeagueRepository;

        public SeasonLeagueController(ISeasonLeagueRepository seasonLeagueRepository)
        {
            _seasonLeagueRepository = seasonLeagueRepository;
        }

        [HttpGet]
        public List<SeasonLeague> GetSeasonLeagues()
        {
            var seasonLeague = _seasonLeagueRepository.GetSeasonLeagues().ToList();
            return seasonLeague;
        }
    }
}