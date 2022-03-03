using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Models;

namespace MyWebAPICore.Data.SeedingDb
{
    public static class SeedAuthors
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData
                (
                    new Author()
                    {
                        Id = 1,
                        Name = "Cloe Hopper",
                        Image = "cloehopper",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1950, 5, 23),
                        Email = "cloehopper@school.com",
                        Deleted = false
                        //Books = new List<Book>()
                    },
                    new Author()
                    {
                        Id = 2,
                        Name = "David Remnick",
                        Image = "davidremnick",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday= new DateTime(1955, 6, 18),
                        Email = "davidremnick@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 3,
                        Name = "Joanna Kavena",
                        Image = "joannakavena",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1967, 1, 12),
                        Email = "joannakavena@gmail.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 4,
                        Name = "John Cheever",
                        Image = "johncheever",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1912, 5, 27),
                        Email = "johncheever@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 5,
                        Name = "Joshua Cohen",
                        Image = "joshuacohen",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1980, 9, 6),
                        Email = "joshuacohen@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 6,
                        Name = "Patrick Ness",
                        Image = "patrickness",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1971, 10, 17),
                        Email = "patrickness@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 7,
                        Name = "Rebecca Swift",
                        Image = "rebeccaswift",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1975, 8, 16),
                        Email = "rebeccaswift@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 8,
                        Name = "Sarah Perry",
                        Image = "sarahperry",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1979, 11, 28),
                        Email = "sarahperry@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 9,
                        Name = "Simon Mawer",
                        Image = "simonmawer",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1948, 12, 26),
                        Email = "simonmawer@school.com",
                        Deleted = false
                    },
                    new Author()
                    {
                        Id = 10,
                        Name = "Tom Winton",
                        Image = "tomwinton",
                        Biography = "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book " +
                        "of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man " +
                        "in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.",
                        Birthday = new DateTime(1960, 8, 4),
                        Email = "tomwinton@school.com",
                        Deleted = false
                    }
                );
        }
    }
}
