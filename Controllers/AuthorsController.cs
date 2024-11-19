using Libreria_RERS.Data.Services;
using Libreria_RERS.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_RERS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsServices; 

        public AuthorsController(AuthorsService authorsServices)
        {
            _authorsServices = authorsServices;


        }
        [HttpPost("add-author")]

        public IActionResult AddAuthor([FromBody]AuthorVM author)
        {
            _authorsServices.AddAuthor(author);
            return Ok();

        }

    }
}
