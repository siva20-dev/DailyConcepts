using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookStoreAPI.Model;

namespace BookStoreAPI.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>

    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
