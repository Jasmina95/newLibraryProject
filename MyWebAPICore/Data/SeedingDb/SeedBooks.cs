using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.SeedingDb
{
    public static class SeedBooks
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData
                (
                    new Book()
                    {
                        Id = 1,
                        Title = "Bloated JabbaScript Frameworks",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "bjsf",
                        Pages = 171,
                        Price = 79.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 2,
                        Title = "Blaming the Architecture",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "bta",
                        Pages = 158,
                        Price = 79.95,
                        PublisherId = 2,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 3,
                        Title = "Blame the Other Guy",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "btog",
                        Price = 69.95,
                        Pages = 111,
                        PublisherId = 3,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 4,
                        Title = "Blaming the User",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "btu",
                        Pages = 152,
                        Price = 69.95,
                        PublisherId = 4,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 5,
                        Title = "Commenting Out Failed Tests",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "coft",
                        Pages = 166,
                        Price = 69.95,
                        PublisherId = 5,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 6,
                        Title = "Copying and Pasting from Stack Overflow",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "cpso",
                        Pages = 159,
                        Price = 69.95,
                        PublisherId = 5,
                        Deleted=false
                    },
                    new Book()
                    {
                        Id = 7,
                        Title = "Changing Stuff and Seeing What Happens",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "cswh",
                        Pages = 129,
                        Price = 59.95,
                        PublisherId = 4,
                        Deleted=false
                    },
                    new Book()
                    {
                        Id = 8,
                        Title = "Coding on the Weekend",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "cw",
                        Pages = 142,
                        Price = 49.95,
                        PublisherId = 3,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 9,
                        Title = "Doing it the Hard Way",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Pages = 113,
                        Image = "dihw",
                        Price = 59.95,
                        PublisherId = 2,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 10,
                        Title = "Excuses to Miss Meetings",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "emm",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 11,
                        Title = "Excuses for Not Writing Documentation",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "endw",
                        Pages = 153,
                        Price = 79.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 12,
                        Title = "Excuses for Not Writing Unit Tests",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "ewut",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 2,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 13,
                        Title = "Forgetting How Your Own COde Works",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "fhcw",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 3,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 14,
                        Title = "Getting an Arduino LED to Blink",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "galb",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 4,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 15,
                        Title = "Getting it to Work",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "gitw",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 5,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 16,
                        Title = "Googling the Error Message",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "gtem",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 5,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 17,
                        Title = "Hating on Languages You Don't use",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "hldu",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 4,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 18,
                        Title = "Hoping Nobody Hacks You",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "hnhy",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 3,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 19,
                        Title = "Hanging out on Slack",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "hoos",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 2,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 20,
                        Title = "Hating Other People's Code",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "hopc",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 21,
                        Title = "Hoping This Works",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "htw",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 22,
                        Title = "It Depends",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "id",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 23,
                        Title = "Memorizing Six Git Commands",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "msgc",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 24,
                        Title = "Programming by Trial and Error",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "pbte",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 25,
                        Title = "Pretending to Know About Stuff",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "pkas",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 26,
                        Title = "Rewriting Your Front End Every Six Weeks",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "rfsw",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 27,
                        Title = "Solving Imaginary Scaling Issues",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "sisi",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 28,
                        Title = "Turning Coffee Into Code",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "tcic",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 29,
                        Title = "Trying Stuff Until it Works",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "tsuw",
                        Pages = 113,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    },
                    new Book()
                    {
                        Id = 30,
                        Title = "Writing Code that Nobody Else Can Read",
                        Description = "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB " +
                        "right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole " +
                        "1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other " +
                        "overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size" +
                        " is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but " +
                        "thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations," +
                        " or other overengineered crap",
                        Image = "wcnr",
                        Pages = 121,
                        Price = 59.95,
                        PublisherId = 1,
                        Deleted = false
                    }
                );

        }
    }
}
