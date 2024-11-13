using Libreria_RERS.Data.Services;
using Libreria_RERS.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_RERS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        public BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;

        }
        [HttpGet("get-all-books")]

        public IActionResult GetAllBooks()
        {
            var allbooks = _booksService.GetAllBks();
            return Ok(allbooks);

        }

        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var allbooks = _booksService.GetBookById(id);
            return Ok(allbooks);
        }
        [HttpPost("add-book")]

        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();

        }
        [HttpPut("update-book-by-id/{id}")]

        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            var updateBook = _booksService.UpdateBookByID(id, book);
            return Ok(updateBook);

        }

    }
}
