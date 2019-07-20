using System.Collections.Generic;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
        IEnumerable<Feedback> GetAllFeedbacks();
    }
}
