using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.SeedingDb
{
    public static class SeedPublishersAndAddresses
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData
                (
                    new Publisher { Id = 1, Name = "Fairview Press", Deleted = false, PublisherAddressId = 1 },
                    new Publisher { Id = 2, Name = "Harlequin Enterprises Ltd", Deleted = false, PublisherAddressId = 2 },
                    new Publisher { Id = 3, Name = "Parragon", Deleted = false, PublisherAddressId = 3 },
                    new Publisher { Id = 4, Name = "Barrie & Jenkins", Deleted = false, PublisherAddressId = 4 },
                    new Publisher { Id = 5, Name = "Times Books", Deleted = false, PublisherAddressId = 5 }
                );

            modelBuilder.Entity<PublisherAddress>().HasData
                (
                    new PublisherAddress() { Id = 1, Road = "2450 Riverside Avenue South", ZipCode = "55401", City = "Minneapolis", Country = "USA" },
                    new PublisherAddress() { Id = 2, Road = "22 Adelaide Street West", ZipCode = "M5H 4E3", City = "Toronto", Country = "CAN" },
                    new PublisherAddress() { Id = 3, Road = "B-38, Sector 5", ZipCode = "BA2", City = "Bath", Country = "ENG" },
                    new PublisherAddress() { Id = 4, Road = "289 Westbourne Grove", ZipCode = "W11 2QA", City = "London", Country = "ENG" },
                    new PublisherAddress() { Id = 5, Road = "115 West 18th Street", ZipCode = "10021", City = "New York", Country = "USA" }
                );
        }
    }
}
