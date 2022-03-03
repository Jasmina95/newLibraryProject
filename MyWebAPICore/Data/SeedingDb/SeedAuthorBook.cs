using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.SeedingDb
{
    public static class SeedAuthorBook
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>().HasData
                (
                    new AuthorBook(){ BookId = 7, AuthorId = 1 },
                    new AuthorBook(){ BookId = 11, AuthorId = 1},
                    new AuthorBook() { BookId = 24, AuthorId = 1},
                    new AuthorBook() { BookId = 28, AuthorId = 1},
                    new AuthorBook() { BookId = 9, AuthorId = 2},
                    new AuthorBook() { BookId = 11, AuthorId = 2},
                    new AuthorBook() { BookId = 19, AuthorId = 2},
                    new AuthorBook() { BookId = 29, AuthorId = 2},
                    new AuthorBook() { BookId = 4, AuthorId = 3},
                    new AuthorBook() { BookId = 12, AuthorId = 3},
                    new AuthorBook() { BookId = 21, AuthorId = 3},
                    new AuthorBook() { BookId = 26, AuthorId = 3},
                    new AuthorBook() { BookId = 15, AuthorId = 4},
                    new AuthorBook() { BookId = 22, AuthorId = 4},
                    new AuthorBook() { BookId = 27, AuthorId = 4},
                    new AuthorBook() { BookId = 2, AuthorId = 5},
                    new AuthorBook() { BookId = 6, AuthorId = 5},
                    new AuthorBook() { BookId = 8, AuthorId = 5},
                    new AuthorBook() { BookId = 10, AuthorId = 5},
                    new AuthorBook() { BookId = 17, AuthorId = 6},
                    new AuthorBook() { BookId = 1, AuthorId = 7},
                    new AuthorBook() { BookId = 5, AuthorId = 7},
                    new AuthorBook() { BookId = 23, AuthorId = 7},
                    new AuthorBook() { BookId = 30, AuthorId = 7},
                    new AuthorBook() { BookId = 3, AuthorId = 8},
                    new AuthorBook() { BookId = 13, AuthorId = 8},
                    new AuthorBook() { BookId = 14, AuthorId = 8},
                    new AuthorBook() { BookId = 17, AuthorId = 9},
                    new AuthorBook() { BookId = 18, AuthorId = 9},
                    new AuthorBook() { BookId = 25, AuthorId = 9},
                    new AuthorBook() { BookId = 29, AuthorId = 9},
                    new AuthorBook() { BookId = 6, AuthorId = 10},
                    new AuthorBook() { BookId = 20, AuthorId = 10}
                );
        }
    }
}
