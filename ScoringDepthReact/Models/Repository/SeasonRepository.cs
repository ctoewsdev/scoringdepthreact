using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly AppDbContext _appDbContext;

        public SeasonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Season> GetSeasons()
        {
            return _appDbContext.Season;
        }
    }
}