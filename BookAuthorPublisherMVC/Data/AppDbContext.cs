using BookAuthorPublisherMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorPublisherMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(ab => new { ab.AuthorId, ab.BookId });

            modelBuilder.Entity<Author_Book>().HasOne(b => b.Book).WithMany(ab => ab.Authors_Books).HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Author_Book>().HasOne(a => a.Author).WithMany(ab => ab.Authors_Books).HasForeignKey(a => a.AuthorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author_Book> Authors_Books { get; set; }
    }
}

