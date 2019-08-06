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
        private readonly ITeamRankingRepository _teamRankingRepository;

        public SeasonRankingController(ISeasonRankingRepository seasonRankingRepository, ITeamRankingRepository teamRankingRepository)
        {
            _seasonRankingRepository = seasonRankingRepository;
            _teamRankingRepository = teamRankingRepository;
        }

        [HttpGet]
        public List<SeasonRanking> GetSeasonRankings()
        {
            return _seasonRankingRepository.GetSeasonRankings().ToList();


        }

        [HttpGet("[action]/{id}")]
        public List<SeasonRanking> GetSeasonRankingsBySLId(long id)
        {
            var seasonRankings = _seasonRankingRepository.GetSeasonRankings(id).ToList();
            var teamRankings = _teamRankingRepository.GetTeamRankings().ToList();

            foreach (SeasonRanking sr in seasonRankings)
            {
                foreach (TeamRanking tr in teamRankings)
                {
                    if (tr.SeasonRankingId == sr.SeasonRankingId)
                    {
                        sr.TeamRankings.Add(tr);
                    }
                }
            }

            return seasonRankings;
        }
    }
}