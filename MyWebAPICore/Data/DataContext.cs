using EntityFramework.Exceptions.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Data.Configurations;
using MyWebAPICore.Data.SeedingDb;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublisherAddress> PublisherAddresses { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }

        // To handle postgreSQL exceptions
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseExceptionProcessor();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherAddressConfiguration());
            modelBuilder.Entity<AuthorBook>().HasKey(ab => new { ab.AuthorId, ab.BookId });

            SeedUsers.Seed(modelBuilder);
            SeedPublishersAndAddresses.Seed(modelBuilder);
            SeedAuthors.Seed(modelBuilder);
            SeedBooks.Seed(modelBuilder);
            SeedAuthorBook.Seed(modelBuilder);
        }


    }
}
