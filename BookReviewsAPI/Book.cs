namespace BookReviewsAPI
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}