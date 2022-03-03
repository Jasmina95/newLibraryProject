using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.SeedingDb
{
    public static class SeedUsers
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            List<User> users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "John Smith",
                    Username = "john",
                    Role = "admin"
                },
                new User()
                {
                    Id = 2,
                    Name = "Ana Boyle",
                    Username = "ana",
                    Role = "admin"
                },
                new User()
                {
                    Id = 3,
                    Name = "Antonio Banderas",
                    Username = "tony",
                    Role = "user"
                },
                new User()
                {
                    Id = 4,
                    Name = "Julio Iglesias",
                    Username = "julio",
                    Role = "user"
                },
                new User()
                {
                    Id = 5,
                    Name = "Placido Iglesias",
                    Username = "place",
                    Role = "user"
                }

            };

            for (int i = 0; i < 5; i++)
            {
                CreatePasswordHash("$ch00l", out byte[] passwordHash, out byte[] passwordSalt);
                users[i].PasswordHash = passwordHash;
                users[i].PasswordSalt = passwordSalt;
            }

            modelBuilder.Entity<User>().HasData(users[0], users[1], users[2], users[3], users[4]);
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
