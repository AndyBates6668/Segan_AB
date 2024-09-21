using BookReviewsAPI.Controllers;
using BookReviewsAPI.Interfaces;
using BookReviewsAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Http.HttpResults;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace BookReviewsAPI.Tests
{
    public class BooksControllerTests
    {
        [Fact]
        public void GetBook_ReturnsBadRequestIfBookDoesNotExist()
        {
            // Arrange.
            var mockBookService = Substitute.For<IBookService>();
            mockBookService.GetBook(Arg.Any<int>())
                .Returns(x =>
                {
                    throw new ArgumentException("Book with id 666 not found.");
                });
            var booksController = new BooksController(mockBookService);

            // Act.
            var response = booksController.GetBook(666);

            // Assert.
            response.Should().NotBeNull();
            var result = response.Result as NotFound<string>;
            result.Should().NotBeNull();
            result.Value.Should().Be("Book with id 666 not found.");
        }

        [Fact]
        public void GetBook_ReturnsOkAndBook()
        {
            // Arrange.
            var mockBookService = Substitute.For<IBookService>();
            mockBookService.GetBook(Arg.Any<int>())
                .Returns(new Book { Id = 1, Author = "Dan Brown", Title = "Da Vinci Code" });
            var booksController = new BooksController(mockBookService);

            // Act.
            var response = booksController.GetBook(1);

            // Assert.
            response.Should().NotBeNull();
            var result = response.Result as Ok<Book>;
            result.Should().NotBeNull();
            result.Value.Id.Should().Be(1);
            result.Value.Author.Should().Be("Dan Brown");
            result.Value.Title.Should().Be("Da Vinci Code");
        }

        [Fact]
        public void GetBooks_ReturnsOkAndNoBooks()
        {
            // Arrange.
            var mockBookService = Substitute.For<IBookService>();
            mockBookService.GetBooks().Returns([]);
            var booksController = new BooksController(mockBookService);

            // Act.
            var response = booksController.GetBooks();

            // Assert.
            response.Should().NotBeNull();
            var result = response.Result as Ok<List<Book>>;
            result.Should().NotBeNull();
            result.Value.Should().BeEmpty();
        }

        [Fact]
        public void GetBooks_ReturnsOkAndBooks()
        {
            // Arrange.
            var mockBookService = Substitute.For<IBookService>();
            mockBookService.GetBooks()
                .Returns([new Book { Id = 1, Author = "Dan Brown", Title = "Da Vinci Code" }]);
            var booksController = new BooksController(mockBookService);

            // Act.
            var response = booksController.GetBooks();

            // Assert.
            response.Should().NotBeNull();
            var result = response.Result as Ok<List<Book>>;
            result.Should().NotBeNull();
            result.Value.Should().HaveCount(1);
        }

        // Review tests follow same pattern above...
    }
}