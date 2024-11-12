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

        [HttpPost("add-book")]

        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();

        }

    }
}
