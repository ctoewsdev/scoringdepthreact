using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class SeasonTeamRepository : ISeasonTeamRepository
    {

        private readonly AppDbContext _appDbContext;

        public SeasonTeamRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SeasonTeam> GetSeasonTeams()
        {
            return _appDbContext.SeasonTeam;
        }
    }
}

