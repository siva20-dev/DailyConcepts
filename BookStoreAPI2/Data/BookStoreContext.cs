using BookStoreAPI2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI2.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {
            
        }

        public DbSet<Books> Books { get; set; } //Table name will be books
    }
}
