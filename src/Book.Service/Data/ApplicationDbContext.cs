using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Book.Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        public DbSet<CategoryViewModel> CategoryViewModels { get; set; }
        public DbSet<PubisherViewModel> PublisherViews { get; set; }
        public DbSet<AuthorViewModel> AuthorViewModels { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<BookPublisher>()
                .HasKey(ba => new { ba.BookId, ba.PublisherId });

            builder.Entity<BookPublisher>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.BookPublishers)
                .HasForeignKey(bg => bg.BookId)
                .OnDelete(DeleteBehavior.Cascade); 

            builder.Entity<BookPublisher>()
                .HasOne(bg => bg.Publisher)
                .WithMany(g => g.BookPublishers)
                .HasForeignKey(bg => bg.PublisherId)
                .OnDelete(DeleteBehavior.Cascade); 

        }
    }
}