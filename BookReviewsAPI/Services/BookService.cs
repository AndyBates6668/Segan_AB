using BookReviewsAPI.Interfaces;
using BookReviewsAPI.Models;
using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public void AddReview(int bookId, Review review)
        {
            throw new System.NotImplementedException();
        }

        public List<Review> GetReviews(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
}
