﻿using BookStoreAPI.Data;
using BookStoreAPI.Model;
using BookStoreAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBookById([FromRoute]int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody]BookModel bookModel)
        {
            var id = await _bookRepository.AddBooksAsync(bookModel);
            return CreatedAtAction(nameof(GetBookById),new { id = id, controller = "books" },id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooks([FromBody] BookModel bookModel, [FromRoute]int id)
        {
            await _bookRepository.UpdateBookAsync(id, bookModel);
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookRepository.UpdateBookPatchAsync(id, bookModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> UpdateBooks([FromRoute] int id)
        {
            await _bookRepository.DeleteBooksAsync(id);
            return Ok();
        }
    }
}
