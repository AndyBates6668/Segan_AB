namespace BookReviewsAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}