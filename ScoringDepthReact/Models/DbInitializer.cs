using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            //if (!context.Country.Any())

            //{
                //Id's added automatically

                var countries = new List<Country>
                {
                    new Country { Name = "Canada", Code="Can", ImageUrl = "canada.jpg" },
                    new Country { Name = "USA", Code ="US", ImageUrl = "usa.jpg" }
                };

                var regions = new List<Region>
                {
                    new Region { Name = "British Columbia", Code = "BC", CountryCode="Can" },
                    new Region { Name = "Alberta", Code = "AB", CountryCode="Can" },
                    new Region { Name = "Saskatchewan", Code = "SK", CountryCode="Can" }
                };

                var seasons = new List<Season>
                {
                    new Season { YearStart = 2018, Name = "2018-19"},
                    new Season { YearStart = 2019, Name = "2019-20"}
                };


                var leagues = new List<League>
                {
                    new League { Name = "British Columbia Junior Hockey League", Code ="BCHL", ImageUrl = "bchl.jpg" },
                    new League { Name = "Pacific Junior Hockey League", Code ="PJHL", ImageUrl = "pjhl.jpg" },
                };

                context.AddRange(countries);
                context.AddRange(regions);
                context.AddRange(seasons);
                context.AddRange(leagues);

                context.SaveChanges();
          //  }
        }
    }
}
