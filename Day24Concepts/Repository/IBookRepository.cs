using BookStoreAPI.Model;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreAPI.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);

        Task<int> AddBooksAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel bookModel);
        Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel);
        Task DeleteBooksAsync(int bookId);
    }
}