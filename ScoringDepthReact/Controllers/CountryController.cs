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
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly ILeagueRepository _leagueRepository;
        private readonly ISeasonRepository _yearRepository;
        private readonly IFeedbackRepository _feedbackRepository;

        private static List<Country> Countries = new List<Country> ()
        {
            new Country() { Name = "hc-Canada", Code="hc-Can", ImageUrl = "hc-canada.jpg" },
            new Country() {Name = "hc-USA", Code ="hc-US", ImageUrl = "hc-usa.jpg" }
        };


        //UDEMY
        //private static List<League> Countries = new List<League>()
        //{
        //    new League (){ Name = "British Columbia Junior Hockey League", Code ="BCHL", ImageUrl = "bchl.jpg" },
        //    new League (){ Name = "Pacific Junior Hockey League", Code ="PJHL", ImageUrl = "pjhl.jpg" },
        //};


        // ctor dependency injection
        public CountryController(ICountryRepository countryRepository, IRegionRepository regionRepository, ILeagueRepository leagueRepository, ISeasonRepository yearRepository, IFeedbackRepository feedbackRepository)
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
        //    var leagues = _leagueRepository.GetAllCountries().OrderBy(l => l.Id);
        //    var seasons = _seasonRepository.GetAllSeasons().OrderBy(s => s.Id);
        //    var feedbacks = _feedbackRepository.GetAllFeedbacks().OrderBy(f => f.Id);

        //    var homeViewModel = new HomeViewModel()
        //    {
        //        Title = Constants.HOME_TITLE,
        //        Countries = countries.ToList(),
        //        Regions = regions.ToList(),
        //        Countries = leagues.ToList(),
        //        Seasons = seasons.ToList(),
        //        Feedbacks = feedbacks.ToList()
        //    };
        //    //return View(homeViewModel);
        //    return homeViewModel;
        //}


        // [HttpGet]Get : does not require tag
        // public IActionResult Index()
        [HttpGet]
        public List<Country> GetCountries()
        {

            var countries = _countryRepository.GetCountries().OrderBy(l => l.CountryId).ToList();



            return countries; 
        }


        // UDEMY
        //[HttpGet]
        //public List<League> GetCountries()
        //{
        //    return Countries;
        //}

        //[HttpGet("[action]/{code}")]
        //public League GetLeague(string code)
        //{
        //    var league = Countries.Find((l) => l.Code.ToLower() == code.ToLower());

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
