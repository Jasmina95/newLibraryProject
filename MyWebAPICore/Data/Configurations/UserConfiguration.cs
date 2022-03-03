using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Name).IsRequired(true);
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.Username).IsRequired(true);
            builder.Property(u => u.Role).IsRequired(true);

        }
    }
}
