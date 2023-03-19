using Microsoft.EntityFrameworkCore;

namespace Ilyuhin_LR2_Backend.Models
{
    public class LibContext : DbContext
    {
        public LibContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet <Ilyuhin_LR2_Backend.Models.Author> Author { get; set; }

        public DbSet <Ilyuhin_LR2_Backend.Models.Book> Book { get; set; }


    }
}
