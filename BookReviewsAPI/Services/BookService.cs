using BookReviewsAPI.Interfaces;
using BookReviewsAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookReviewsAPI.Services
{
    public class BookService : IBookService
    {
        private List<Book> _books = [];

        public BookService()
        {
            _books.Add(new Book { Id = 1, Author = "Dan Brown", Title = "Da Vinci Code"});
        }

        public void Clear()
        {
            _books.Clear();
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBook(int bookId)
        {
            var book = _books.SingleOrDefault(book => book.Id == bookId);
            if (null == book)
                throw new System.ArgumentException($"Book with id {bookId} not found.");
            return book;
        }

        public void AddReview(int bookId, Review review)
        {
            var book = _books.SingleOrDefault(book => book.Id == bookId);

            if (null == book)
                throw new System.ArgumentException($"Book with id {bookId} not found.");

            book.Reviews.Add(review);
        }

        public List<Review> GetReviews(int bookId)
        {
            var book = _books.SingleOrDefault(book => book.Id == bookId);

            if (null == book)
                throw new System.ArgumentException($"Book with id {bookId} not found.");

            return book.Reviews;
        }
    }
}
