using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.Configurations

{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasIndex(b => b.Title).IsUnique();
            builder.Property(b => b.Title).IsRequired(true);
        }


    }
}
