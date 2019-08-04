namespace ScoringDepthReact.Models.Domain
{
    public class Feedback
    {
        public long FeedbackId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool ContactMe { get; set; }
        public bool IsProcessed { get; set; }
    }
}
