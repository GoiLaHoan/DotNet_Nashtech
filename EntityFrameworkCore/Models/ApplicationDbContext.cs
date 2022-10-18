using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Models
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; } = null!;
    }
}