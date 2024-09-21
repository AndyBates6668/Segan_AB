using Microsoft.AspNetCore.Mvc;

namespace BookReviewsAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(new List<Book>());
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            return NotFound();
        }

        [HttpPost("{id}/reviews")]
        public IActionResult AddReview(int id, [FromBody] Review review)
        {
            return NoContent();
        }

        [HttpGet("{id}/reviews")]
        public IActionResult GetReviews(int id)
        {
            return Ok(new List<Review>());
        }
    }
}