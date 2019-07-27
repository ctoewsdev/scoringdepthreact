using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class RegionRepository : IRegionRepository
    {

        private readonly AppDbContext _appDbContext;

        public RegionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Region> GetRegions()
        {
            return _appDbContext.Region;
        }

        public Region GetRegionById(int regionId)
        {
            return _appDbContext.Region.FirstOrDefault(r => r.RegionId == regionId);
        }
    }
}

