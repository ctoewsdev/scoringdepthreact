using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SdIndexRepository : ISdIndexRepository
    {
        private readonly AppDbContext _appDbContext;

        public SdIndexRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SdIndex> GetSdIndices()
        {
            return _appDbContext.SdIndex;
        }
    }
}