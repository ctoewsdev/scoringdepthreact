using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class SeasonRankingController : Controller
    {
        private readonly ISeasonRankingRepository _seasonRankingRepository;

        public SeasonRankingController(ISeasonRankingRepository seasonRankingRepository)
        {
            _seasonRankingRepository = seasonRankingRepository;
        }

        [HttpGet]
        public List<SeasonRanking> GetSeasonRankings()
        {
            return _seasonRankingRepository.GetSeasonRankings().ToList();

        }
    }
}