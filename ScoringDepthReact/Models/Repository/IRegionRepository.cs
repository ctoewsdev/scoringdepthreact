using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetRegions();
        Region GetRegionById(int regionId);
    }
}
