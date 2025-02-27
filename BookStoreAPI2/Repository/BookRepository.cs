﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreAPI2.Data;
using BookStoreAPI2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Microsoft.AspNetCore.JsonPatch;
using AutoMapper;


namespace BookStoreAPI2.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BookStoreContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var records = await _context.Books.ToListAsync();

            return _mapper.Map<List<BookModel>>(records);
        }

        public async Task<BookModel> GetBookByIdAsync(int bookId)
        {
            //var records = await _context.Books.Where(book => book.Id == bookId).Select(x => new BookModel()
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Description = x.Description
            //}).FirstOrDefaultAsync();

            //return records;

            var book = await _context.Books.FindAsync(bookId);
            return _mapper.Map<BookModel>(book);
        }

        public async Task<int> AddANewBookAsync(BookModel bookModel)
        {
            var book = new Books()

            {
                Title = bookModel.Title,
                Description = bookModel.Description
            };

            _context.Books.Add(book);
           await _context.SaveChangesAsync();

            return book.Id;
        }

        public async Task UpdateBookAsync(int bookId,BookModel bookModel)
        {
            var book = new Books()
            {
                Id = bookId,
                Title = bookModel.Title,
                Description = bookModel.Description
            };

            _context.Books.Update(book);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = new Books() { Id = bookId };

            _context.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
