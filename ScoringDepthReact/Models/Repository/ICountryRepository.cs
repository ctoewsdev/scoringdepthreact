using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
        Country GetCountryById(int countryId);
    }
}