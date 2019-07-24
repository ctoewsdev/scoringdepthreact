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
    public class FeedbackController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly ILeagueRepository _leagueRepository;
        private readonly IYearRepository _yearRepository;
        private readonly IFeedbackRepository _feedbackRepository;

        //private static List<League> Leagues = new List<League> ()
        //{
        //    new League() { Name = "hc-British Columbia Junior Hockey League", Code ="hc-BCHL", ImageUrl = "hc-bchl.jpg" },
        //    new League() { Name = "hc-Pacific Junior Hockey League", Code ="hc-PJHL", ImageUrl = "hc-pjhl.jpg" }
        //};

        //private static List<Region> regions = new List<Region>()
        //{
        //    new Region() { Name = "British Columbia", Code = "BC", CountryCode="Can" },
        //    new Region() { Name = "Alberta", Code = "AB", CountryCode="Can" },
        //    new Region() { Name = "Saskatchewan", Code = "SK", CountryCode="Can" }
        //};

        // ctor dependency injection
        public FeedbackController(ICountryRepository countryRepository, IRegionRepository regionRepository, ILeagueRepository leagueRepository, IYearRepository yearRepository, IFeedbackRepository feedbackRepository)
        {

            _countryRepository = countryRepository;
            _regionRepository = regionRepository;
            _leagueRepository = leagueRepository;
            _yearRepository = yearRepository;
            _feedbackRepository = feedbackRepository;
        }

        // [HttpGet]Get : does not require tag
        // public IActionResult Index()
        //public HomeViewModel GeHomeViewModel()
        //{

        //    var countries = _countryRepository.GetAllCountries().OrderBy(c => c.Id);
        //    var regions = _regionRepository.GetAllRegions().OrderBy(r => r.Id);
        //    var leagues = _leagueRepository.GetAllLeagues().OrderBy(l => l.Id);
        //    var seasons = _seasonRepository.GetAllSeasons().OrderBy(s => s.Id);
        //    var feedbacks = _feedbackRepository.GetAllFeedbacks().OrderBy(f => f.Id);

        //    var homeViewModel = new HomeViewModel()
        //    {
        //        Title = Constants.HOME_TITLE,
        //        Countries = countries.ToList(),
        //        Regions = regions.ToList(),
        //        Leagues = leagues.ToList(),
        //        Seasons = seasons.ToList(),
        //        Feedbacks = feedbacks.ToList()
        //    };
        //    //return View(homeViewModel);
        //    return homeViewModel;
        //}


        // [HttpGet]Get : does not require tag
        // public IActionResult Index()
        //[HttpGet]
        //public List<Season> GetSeasons()
        //{
        //    var seasons = _seasonRepository.GetAllSeasons().OrderBy(l => l.SeasonId).ToList();


        //    return seasons;

        //}


        // POST: api/feedback
        [HttpPost]
        public IActionResult CreateFeedback(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          _feedbackRepository.CreateFeedback(feedback);


          return CreatedAtAction("CreateFeedback", new { id = feedback.FeedbackId }, feedback);
        }
        // UDEMY
        //[HttpGet]
        //public List<League> GetLeagues()
        //{
        //    return Leagues;
        //}

        //[HttpGet("[action]/{code}")]
        //public League GetLeague(string code)
        //{
        //    var league = Leagues.Find((l) => l.Code.ToLower() == code.ToLower());

        //    if (league == null)
        //    {
        //        return null;
        //    }

        //        return league;

        //}

        //public class League
        //{
        //    public string Name { get; set; }
        //    public string Code { get; set; }
        //    public string ImageUrl { get; set; }
        //}

    }
}
