using BookReviewsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookReviewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/reviews")]
        public IActionResult AddReview(int id, [FromBody] Review review)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/reviews")]
        public IActionResult GetReviews(int id)
        {
            throw new NotImplementedException();
        }
    }
}