using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAllRegions();
        Region GetRegionById(int regionId);
    }
}
