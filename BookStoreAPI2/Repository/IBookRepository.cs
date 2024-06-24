using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreAPI2.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace BookStoreAPI2.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddANewBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel bookModel);

        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel);
        Task DeleteBookAsync(int bookId);
    }
}