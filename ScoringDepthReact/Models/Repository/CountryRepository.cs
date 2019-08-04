using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> GetCountries()
        {
            return _appDbContext.Country;
        }

        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Country.FirstOrDefault(c => c.CountryId == countryId);
        }
    }
}