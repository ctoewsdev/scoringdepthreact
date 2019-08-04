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
    public class SeasonTeamController : Controller
    {
        private readonly ISeasonTeamRepository _seasonTeamRepository;

        public SeasonTeamController(ISeasonTeamRepository seasonTeamRepository)
        {
            _seasonTeamRepository = seasonTeamRepository;
        }

        [HttpGet]
        public List<SeasonTeam> GetSeasonTeams()
        {
            var seasonTeams = _seasonTeamRepository.GetSeasonTeams().ToList();
            return seasonTeams;
        }
    }
}
