using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasIndex(a => a.Name).IsUnique();
            builder.Property(a => a.Name).IsRequired(true);
            builder.HasIndex(a => a.Email).IsUnique();
            builder.Property(a => a.Email).IsRequired(true);

        }


    }
}
