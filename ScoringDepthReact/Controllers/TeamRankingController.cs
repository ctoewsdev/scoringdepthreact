using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class TeamRankingController : Controller
    {
        private readonly ITeamRankingRepository _teamRankingRepository;

        public TeamRankingController(ITeamRankingRepository teamRankingRepository)
        {
            _teamRankingRepository = teamRankingRepository;
        }

        [HttpGet]
        public List<TeamRanking> GetTeamRankings()
        {
            return _teamRankingRepository.GetTeamRankings().ToList(); ;
        }
    }
}
