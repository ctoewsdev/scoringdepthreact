using System.Collections.Generic;
using ScoringDepthReact.Models;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Country> Countries { get; set; }
        public List<Region> Regions { get; set; }
        public List<League> Leagues { get; set; }
        public List<Year> Seasons { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
