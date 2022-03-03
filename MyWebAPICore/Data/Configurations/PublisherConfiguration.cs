using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.Name).IsRequired();

        }



    }
}
