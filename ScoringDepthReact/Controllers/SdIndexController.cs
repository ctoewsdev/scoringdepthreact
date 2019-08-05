using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ScoringDepthReact.Models.Domain;
using ScoringDepthReact.Models.Repository;

namespace ScoringDepthReact.Controllers
{
    [Route("api/[controller]")]
    public class SdIndexController : Controller
    {
        private readonly ISdIndexRepository _rankingRepository;

        public SdIndexController(ISdIndexRepository rankingRepository)
        {
            _rankingRepository = rankingRepository;
        }

        [HttpGet]
        public List<SdIndex> GetSdIndices()
        {
            return _rankingRepository.GetSdIndices().ToList();
        }
    }
}
