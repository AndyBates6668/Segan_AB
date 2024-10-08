using System.Collections.Generic;

namespace BookReviewsAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<Review> Reviews { get; set; } = [];
    }
}