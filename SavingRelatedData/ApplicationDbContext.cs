using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingRelatedData
{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Post> Posts { get; set; } 
        //public DbSet<Blog> Blogs { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UMMUHANKURT;Database=Application;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.Authors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(ba => ba.AuthorId);
               
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Blog>()
        //        .HasMany(b => b.Posts)
        //        .WithOne(p => p.Blog)
        //        .HasForeignKey(p => p.BlogId);
        //}
    }
}
