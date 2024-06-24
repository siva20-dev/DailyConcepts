using BookStoreAPI2.Models;
using BookStoreAPI2.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStoreAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookrepository;

        public BooksController(IBookRepository bookrepository)
        {
            _bookrepository = bookrepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookrepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBookById([FromRoute]int id)
        {
            var book = await _bookrepository.GetBookByIdAsync(id);
            if (book == null)
            {
               return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddANewBook([FromBody] BookModel bookModel)
        {
            var id = await _bookrepository.AddANewBookAsync(bookModel);

            return CreatedAtAction(nameof(GetBookById), new { id = id, controller = "books" }, id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] BookModel bookModel, [FromRoute] int id)
        {
           await _bookrepository.UpdateBookAsync(id,bookModel);

           return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody]JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookrepository.UpdateBookPatchAsync(id, bookModel);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookrepository.DeleteBookAsync(id);

            return Ok();
        }
    }
}
