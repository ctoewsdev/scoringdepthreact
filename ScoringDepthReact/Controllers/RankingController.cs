using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Common;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;
using ScoringDepthReact.Models.ViewModels;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class RankingController : Controller
    {
        private readonly IRankingRepository _rankingRepository;

        public RankingController(IRankingRepository rankingRepository)
        {
            _rankingRepository = rankingRepository;
        }

        [HttpGet]
        public List<Ranking> GetRankings()
        {
            var rankings = _rankingRepository.GetRankings().ToList();
            return rankings;
        }
    }
}
