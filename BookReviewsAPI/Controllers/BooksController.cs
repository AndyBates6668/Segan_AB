using BookReviewsAPI.Interfaces;
using BookReviewsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace BookReviewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public Results<Ok<List<Book>>, NoContent> GetBooks()
        {
            var books = _bookService.GetBooks();
            return TypedResults.Ok(books);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public Results<Ok<Book>, NotFound<string>> GetBook(int id)
        {
            try
            {
                var book = _bookService.GetBook(id);
                return TypedResults.Ok(book);
            }
            catch (ArgumentException e)
            {
                return TypedResults.NotFound(e.Message);
            }
        }

        [HttpPost("{id}/reviews")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public Results<Created<string>, BadRequest<string>> AddReview(int id, [FromBody] Review review)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/reviews")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public Results<Ok<List<Book>>, BadRequest<string>> GetReviews(int id)
        {
            throw new NotImplementedException();
        }
    }
}