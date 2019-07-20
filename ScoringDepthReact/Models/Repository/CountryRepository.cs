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

        //public CountryRepository()
        //{
        //    if (_countries == null)
        //    {
        //        InitializeCountries();
        //    }
        //}

        //private void InitializeCountries()
        //{
        //    _countries = new List<Country>
        //    {
        //        new Country() {Id = 1, Name = "Canada", ImageUrl = "canada.jpg"},
        //        new Country() { Id = 2, Name = "USA", ImageUrl = "usa.jpg"}
        //    };
        //}
    
        public IEnumerable<Country> GetAllCountries()
        {
            //populate collection from country table on DB (or DBContext if already loaded)
            return _appDbContext.Country;
        }

        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Country.FirstOrDefault(c => c.Id == countryId);
        }
    }
}

