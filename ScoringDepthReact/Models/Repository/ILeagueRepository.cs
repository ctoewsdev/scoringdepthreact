using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface ILeagueRepository
    {
        IEnumerable<League> GetAllLeagues();
        League GetLeagueById(int leagueId);
    }
}
