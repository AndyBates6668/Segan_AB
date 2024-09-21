using Xunit;

namespace BookReviewsAPI.Tests
{
    public class BookServiceTests
    {
        //private readonly IBookService _bookService;

        public BookServiceTests()
        {
            //_bookService = new BookService();
        }

        [Fact]
        public void GetAllBooks_ShouldReturn_EmptyList_IfNoBooksExist()
        {
            // Test the implementation when there are no books
            //Assert.Throws<NotImplementedException>(() => _bookService.GetAllBooks());
        }

        // Additional test cases can be added here as part of the task
    }
}