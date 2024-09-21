using BookReviewsAPI.Interfaces;
using BookReviewsAPI.Models;
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
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public Results<Ok<Book>, BadRequest<string>> GetBook(int id)
        {
            throw new NotImplementedException();
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