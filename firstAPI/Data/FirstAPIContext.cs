using firstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace firstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options): base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
