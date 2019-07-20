using System.Collections.Generic;
using System.Linq;
using ScoringDepthReact.Models.Domain;

namespace ScoringDepthReact.Models.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {

        private readonly AppDbContext _appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedback.Add(feedback);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _appDbContext.Feedback;
        }
    }
}

