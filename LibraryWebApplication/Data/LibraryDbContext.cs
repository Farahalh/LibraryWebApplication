using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LibraryApi.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BooksCopy { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public LibraryDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=ITHS-HP-EB-059\SQLEXPRESS;Database=MyDb;Trusted_Connection=True;TrustServerCertificate=True;")
            .LogTo(message => Debug.WriteLine(message))
                .EnableSensitiveDataLogging();
        }
    }
}
