using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.Configurations
{
    public class PublisherAddressConfiguration : IEntityTypeConfiguration<PublisherAddress>
    {
        public void Configure(EntityTypeBuilder<PublisherAddress> builder)
        {
            builder.Property(pa => pa.Road).IsRequired(true);
            builder.Property(pa => pa.ZipCode).IsRequired(true);
            builder.Property(pa => pa.City).IsRequired(true);
            builder.Property(pa => pa.Country).IsRequired(true);

        }
    }
}
