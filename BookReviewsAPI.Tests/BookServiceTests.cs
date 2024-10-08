using BookReviewsAPI.Services;
using FluentAssertions;
using System;
using Xunit;

namespace BookReviewsAPI.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetBook_ShouldThrowArgumentException_IfBookDoesNotExist()
        {
            // Arrange.
            var bookService = new BookService();

            // Act.
            void getBook() => bookService.GetBook(666);

            // Assert.
            var exception = Assert.Throws<ArgumentException>(getBook);
            exception.Message.Should().Be("Book with id 666 not found.");
        }

        [Fact]
        public void GetBook_ShouldReturn_Book_IfBookExists()
        {
            // Arrange.
            var bookService = new BookService();

            // Act.
            var book = bookService.GetBook(1);

            // Assert.
            book.Should().NotBeNull();
            book.Id.Should().Be(1);
        }

        [Fact]
        public void GetBooks_ShouldReturn_EmptyList_IfNoBooksExist()
        {
            // Arrange.
            var bookService = new BookService();
            bookService.Clear();

            // Act.
            var books = bookService.GetBooks();

            // Assert.
            books.Should().BeEmpty();
        }

        [Fact]
        public void GetBooks_ShouldReturn_List_IfBooksExist()
        {
            // Arrange.
            var bookService = new BookService();

            // Act.
            var books = bookService.GetBooks();

            // Assert.
            books.Should().HaveCount(1);
        }

        // Review tests follow same pattern above...
    }
}