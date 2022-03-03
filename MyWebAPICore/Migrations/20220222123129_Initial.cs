using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyWebAPICore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Biography = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublisherAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Road = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    PublisherAddressId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_PublisherAddresses_PublisherAddressId",
                        column: x => x.PublisherAddressId,
                        principalTable: "PublisherAddresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Pages = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "Birthday", "Deleted", "Email", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1950, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "cloehopper@school.com", "cloehopper", "Cloe Hopper" },
                    { 2, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1955, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "davidremnick@school.com", "davidremnick", "David Remnick" },
                    { 3, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "joannakavena@gmail.com", "joannakavena", "Joanna Kavena" },
                    { 4, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1912, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "johncheever@school.com", "johncheever", "John Cheever" },
                    { 5, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1980, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "joshuacohen@school.com", "joshuacohen", "Joshua Cohen" },
                    { 6, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1971, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "patrickness@school.com", "patrickness", "Patrick Ness" },
                    { 7, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1975, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "rebeccaswift@school.com", "rebeccaswift", "Rebecca Swift" },
                    { 8, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1979, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "sarahperry@school.com", "sarahperry", "Sarah Perry" },
                    { 9, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1948, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "simonmawer@school.com", "simonmawer", "Simon Mawer" },
                    { 10, "Australian author Chloe Hooper, 39, is creating a singularly diverse literary career. Her 2002 debut novel, A Child's Book of True Crime, made the Orange prize shortlist, while The Tall Man (2009), a nonfiction investigation into the death of an Aboriginal man in police custody, earned praise from Philip Roth and Peter Carey. Her new novel is a gothic thriller, The Engagement.", new DateTime(1960, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "tomwinton@school.com", "tomwinton", "Tom Winton" }
                });

            migrationBuilder.InsertData(
                table: "PublisherAddresses",
                columns: new[] { "Id", "City", "Country", "Road", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Minneapolis", "USA", "2450 Riverside Avenue South", "55401" },
                    { 2, "Toronto", "CAN", "22 Adelaide Street West", "M5H 4E3" },
                    { 3, "Bath", "ENG", "B-38, Sector 5", "BA2" },
                    { 4, "London", "ENG", "289 Westbourne Grove", "W11 2QA" },
                    { 5, "New York", "USA", "115 West 18th Street", "10021" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "John Smith", new byte[] { 41, 146, 219, 176, 76, 84, 135, 79, 125, 50, 47, 54, 62, 195, 240, 91, 80, 16, 96, 118, 59, 231, 232, 136, 88, 46, 149, 116, 1, 47, 75, 155, 0, 211, 206, 122, 153, 220, 184, 198, 30, 20, 74, 229, 189, 67, 71, 36, 191, 16, 176, 157, 136, 85, 43, 121, 11, 116, 158, 48, 14, 115, 105, 182 }, new byte[] { 221, 54, 193, 151, 62, 200, 185, 87, 25, 63, 145, 127, 83, 125, 55, 247, 103, 104, 243, 143, 90, 50, 80, 245, 112, 101, 74, 32, 11, 234, 116, 207, 26, 33, 225, 163, 81, 41, 96, 223, 250, 105, 185, 82, 132, 22, 185, 154, 149, 199, 250, 48, 52, 225, 55, 6, 24, 30, 125, 137, 121, 82, 70, 78, 34, 236, 110, 126, 160, 219, 73, 89, 178, 45, 149, 219, 163, 78, 9, 63, 119, 137, 8, 135, 196, 55, 180, 2, 154, 199, 37, 205, 195, 104, 10, 197, 27, 247, 122, 52, 106, 135, 50, 127, 132, 36, 99, 37, 192, 106, 211, 103, 105, 222, 221, 47, 74, 130, 0, 144, 221, 213, 255, 70, 130, 172, 166, 215 }, "admin", "john" },
                    { 2, "Ana Boyle", new byte[] { 93, 184, 198, 108, 125, 79, 137, 215, 9, 56, 210, 70, 85, 177, 71, 166, 123, 193, 59, 121, 237, 120, 111, 181, 20, 243, 219, 243, 153, 5, 90, 193, 67, 219, 200, 77, 60, 251, 227, 19, 14, 241, 153, 230, 34, 95, 249, 46, 254, 103, 30, 61, 111, 190, 49, 121, 202, 160, 9, 27, 171, 208, 113, 79 }, new byte[] { 28, 209, 118, 158, 60, 161, 140, 201, 31, 191, 125, 166, 93, 219, 54, 189, 61, 169, 98, 6, 44, 15, 91, 157, 82, 145, 57, 167, 120, 71, 255, 230, 171, 212, 233, 124, 25, 128, 35, 203, 247, 245, 164, 117, 5, 135, 78, 227, 241, 103, 97, 154, 88, 255, 97, 108, 111, 130, 45, 29, 23, 228, 124, 221, 139, 219, 117, 51, 242, 82, 114, 104, 155, 47, 204, 78, 216, 98, 203, 180, 75, 84, 40, 3, 79, 157, 103, 10, 50, 86, 252, 225, 141, 84, 208, 132, 143, 32, 14, 5, 73, 243, 94, 139, 254, 31, 93, 6, 1, 180, 39, 42, 28, 238, 93, 159, 72, 161, 200, 149, 154, 208, 247, 15, 226, 163, 219, 205 }, "admin", "ana" },
                    { 3, "Antonio Banderas", new byte[] { 171, 220, 92, 89, 250, 35, 20, 67, 129, 49, 45, 87, 146, 230, 192, 206, 148, 180, 67, 60, 40, 90, 158, 230, 41, 36, 214, 139, 34, 117, 31, 198, 42, 194, 218, 118, 31, 138, 223, 53, 233, 1, 183, 127, 18, 130, 92, 175, 141, 29, 102, 223, 136, 10, 224, 66, 247, 215, 148, 22, 6, 72, 159, 182 }, new byte[] { 172, 107, 161, 237, 223, 119, 221, 167, 68, 159, 26, 14, 125, 95, 168, 200, 43, 75, 142, 251, 51, 219, 158, 39, 130, 136, 242, 87, 80, 216, 79, 38, 175, 204, 252, 148, 92, 81, 83, 206, 48, 121, 222, 242, 144, 91, 53, 211, 90, 137, 227, 72, 249, 179, 170, 167, 158, 184, 185, 85, 207, 233, 245, 21, 235, 131, 148, 31, 250, 121, 120, 3, 40, 151, 38, 15, 161, 192, 92, 150, 0, 108, 117, 4, 47, 68, 186, 127, 166, 160, 149, 183, 72, 44, 76, 185, 177, 200, 75, 209, 61, 230, 160, 119, 162, 106, 219, 107, 95, 83, 115, 197, 189, 95, 190, 225, 250, 130, 2, 89, 5, 110, 99, 248, 6, 25, 101, 186 }, "user", "tony" },
                    { 4, "Julio Iglesias", new byte[] { 46, 248, 145, 152, 61, 180, 121, 193, 49, 54, 41, 31, 226, 34, 156, 223, 110, 71, 44, 19, 164, 222, 238, 214, 42, 245, 211, 52, 60, 148, 222, 117, 67, 35, 14, 234, 42, 133, 45, 196, 219, 178, 217, 123, 39, 144, 157, 136, 137, 114, 170, 21, 211, 200, 180, 101, 32, 84, 229, 12, 104, 56, 182, 217 }, new byte[] { 70, 173, 194, 96, 55, 92, 125, 173, 88, 60, 94, 194, 152, 88, 128, 10, 187, 224, 27, 54, 191, 120, 154, 39, 249, 235, 90, 88, 67, 215, 210, 93, 46, 214, 239, 251, 152, 210, 132, 13, 156, 218, 199, 209, 29, 33, 222, 47, 106, 39, 19, 182, 71, 73, 225, 25, 156, 200, 192, 49, 86, 28, 105, 247, 243, 148, 214, 192, 57, 236, 98, 154, 107, 11, 238, 19, 92, 127, 177, 181, 150, 233, 75, 117, 86, 51, 121, 245, 49, 131, 239, 90, 173, 167, 136, 186, 138, 238, 144, 132, 245, 59, 182, 47, 150, 226, 151, 243, 65, 61, 168, 175, 90, 172, 210, 115, 44, 195, 231, 127, 186, 118, 20, 174, 44, 71, 174, 239 }, "user", "julio" },
                    { 5, "Placido Iglesias", new byte[] { 120, 179, 248, 19, 23, 97, 152, 28, 135, 26, 58, 184, 67, 124, 152, 85, 154, 190, 156, 107, 176, 75, 187, 193, 189, 81, 247, 87, 0, 226, 8, 230, 191, 81, 64, 201, 207, 183, 48, 239, 96, 142, 198, 219, 112, 106, 78, 5, 193, 230, 14, 148, 218, 74, 87, 84, 235, 122, 199, 141, 228, 165, 63, 85 }, new byte[] { 18, 214, 72, 182, 37, 168, 80, 22, 109, 136, 104, 93, 7, 214, 171, 133, 175, 73, 26, 236, 161, 204, 71, 21, 90, 24, 237, 247, 90, 94, 189, 2, 12, 81, 40, 146, 141, 104, 85, 244, 246, 34, 119, 158, 150, 247, 145, 109, 18, 139, 54, 17, 153, 190, 196, 92, 70, 94, 52, 79, 198, 56, 120, 191, 255, 167, 161, 1, 160, 246, 131, 32, 140, 11, 27, 76, 212, 30, 125, 225, 92, 122, 210, 191, 103, 157, 76, 188, 144, 145, 48, 41, 168, 134, 45, 120, 147, 221, 17, 101, 4, 60, 183, 121, 0, 166, 4, 109, 206, 42, 109, 236, 240, 78, 211, 53, 211, 146, 92, 94, 68, 153, 208, 44, 172, 91, 192, 50 }, "user", "place" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Deleted", "Name", "PublisherAddressId" },
                values: new object[,]
                {
                    { 1, false, "Fairview Press", 1 },
                    { 2, false, "Harlequin Enterprises Ltd", 2 },
                    { 3, false, "Parragon", 3 },
                    { 4, false, "Barrie & Jenkins", 4 },
                    { 5, false, "Times Books", 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Deleted", "Description", "Image", "Pages", "Price", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 1, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "bjsf", 171, 79.950000000000003, 1, "Bloated JabbaScript Frameworks" },
                    { 2, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "bta", 158, 79.950000000000003, 2, "Blaming the Architecture" },
                    { 3, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "btog", 111, 69.950000000000003, 3, "Blame the Other Guy" },
                    { 4, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "btu", 152, 69.950000000000003, 4, "Blaming the User" },
                    { 5, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "coft", 166, 69.950000000000003, 5, "Commenting Out Failed Tests" },
                    { 6, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "cpso", 159, 69.950000000000003, 5, "Copying and Pasting from Stack Overflow" },
                    { 7, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "cswh", 129, 59.950000000000003, 4, "Changing Stuff and Seeing What Happens" },
                    { 8, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "cw", 142, 49.950000000000003, 3, "Coding on the Weekend" },
                    { 9, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "dihw", 113, 59.950000000000003, 2, "Doing it the Hard Way" },
                    { 10, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "emm", 113, 59.950000000000003, 1, "Excuses to Miss Meetings" },
                    { 11, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "endw", 153, 79.950000000000003, 1, "Excuses for Not Writing Documentation" },
                    { 12, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "ewut", 113, 59.950000000000003, 2, "Excuses for Not Writing Unit Tests" },
                    { 13, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "fhcw", 113, 59.950000000000003, 3, "Forgetting How Your Own COde Works" },
                    { 14, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "galb", 113, 59.950000000000003, 4, "Getting an Arduino LED to Blink" },
                    { 15, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "gitw", 113, 59.950000000000003, 5, "Getting it to Work" },
                    { 16, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "gtem", 113, 59.950000000000003, 5, "Googling the Error Message" },
                    { 17, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "hldu", 113, 59.950000000000003, 4, "Hating on Languages You Don't use" },
                    { 18, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "hnhy", 113, 59.950000000000003, 3, "Hoping Nobody Hacks You" },
                    { 19, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "hoos", 113, 59.950000000000003, 2, "Hanging out on Slack" },
                    { 20, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "hopc", 113, 59.950000000000003, 1, "Hating Other People's Code" },
                    { 21, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "htw", 113, 59.950000000000003, 1, "Hoping This Works" },
                    { 22, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "id", 113, 59.950000000000003, 1, "It Depends" },
                    { 23, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "msgc", 113, 59.950000000000003, 1, "Memorizing Six Git Commands" },
                    { 24, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "pbte", 113, 59.950000000000003, 1, "Programming by Trial and Error" },
                    { 25, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "pkas", 113, 59.950000000000003, 1, "Pretending to Know About Stuff" },
                    { 26, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "rfsw", 113, 59.950000000000003, 1, "Rewriting Your Front End Every Six Weeks" },
                    { 27, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "sisi", 113, 59.950000000000003, 1, "Solving Imaginary Scaling Issues" },
                    { 28, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "tcic", 113, 59.950000000000003, 1, "Turning Coffee Into Code" },
                    { 29, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "tsuw", 113, 59.950000000000003, 1, "Trying Stuff Until it Works" },
                    { 30, false, "Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap. Its amazing how loading a single webpage can cost you upwards of ~5MB. I think the average web page size is 3MB right now, I remember reading that somewhere, dont remember where though.<br>Might not matter when using wifi, but thats a whole 1% of my monthly cell data. 100 pages a month and im done. All of this for what? Usually some annoying animations, or other overengineered crap", "wcnr", 121, 59.950000000000003, 1, "Writing Code that Nobody Else Can Read" }
                });

            migrationBuilder.InsertData(
                table: "AuthorBooks",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 1, 11 },
                    { 1, 24 },
                    { 1, 28 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 19 },
                    { 2, 29 },
                    { 3, 4 },
                    { 3, 12 },
                    { 3, 21 },
                    { 3, 26 },
                    { 4, 15 },
                    { 4, 22 },
                    { 4, 27 },
                    { 5, 2 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 17 },
                    { 7, 1 },
                    { 7, 5 },
                    { 7, 23 },
                    { 7, 30 },
                    { 8, 3 },
                    { 8, 13 },
                    { 8, 14 },
                    { 9, 17 },
                    { 9, 18 },
                    { 9, 25 },
                    { 9, 29 },
                    { 10, 6 },
                    { 10, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_BookId",
                table: "AuthorBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Email",
                table: "Authors",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Name",
                table: "Authors",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title",
                table: "Books",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_Name",
                table: "Publishers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_PublisherAddressId",
                table: "Publishers",
                column: "PublisherAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "PublisherAddresses");
        }
    }
}
