using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class TeamRepository : ITeamRepository
    {

        private readonly AppDbContext _appDbContext;

        public TeamRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Load data into underlying DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Team> GetTeams()
        {
            return _appDbContext.Team;
        }
    }
}

