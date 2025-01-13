using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LibraryApi.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; } 
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Checkout> Checkout { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
            options.LogTo(message => Debug.WriteLine(message))
                .EnableSensitiveDataLogging();
        }
    }
}
