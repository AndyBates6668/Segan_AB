using BookReviewsAPI.Models;
using System.Collections.Generic;

namespace BookReviewsAPI.Interfaces
{
    public interface IBookService
    {
        public void Clear();

        List<Book> GetBooks();
        Book GetBook(int bookId);

        void AddReview(int bookId, Review review);
        List<Review> GetReviews(int bookId);
    }
}
