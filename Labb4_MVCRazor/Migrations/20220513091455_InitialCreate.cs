using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4_MVCRazor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCategory = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActiveBorrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveBorrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveBorrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActiveBorrows_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnedBorrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnedBorrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnedBorrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnedBorrows_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookCategory", "Description", "ImageUrl", "Published", "SerialNumber", "Title" },
                values: new object[,]
                {
                    { 1, "John Ajvide Lindqvist", 1, "If fiction’s taught us anything in recent years, it’s that the vampire genre can be a tired—and ironically toothless—one. But Swedish writer John Ajvide Lindqvist breathed new life into the eternally overdone tale with his debut novel, Let the Right One In, which tells the story of a bullied grade-school student named Oskar and his new friend and neighbor, Eli.", "https://upload.wikimedia.org/wikipedia/en/b/bf/Lettherightoneinswedishbookcover.jpg", 2004, "x11111", "Let The Right One in" },
                    { 2, "Stephen King", 1, "If fiction’s taught us anything in recent years, it’s that the vampire genre can be a tired—and ironically toothless—one. But Swedish writer John Ajvide Lindqvist breathed new life into the eternally overdone tale with his debut novel, Let the Right One In, which tells the story of a bullied grade-school student named Oskar and his new friend and neighbor, Eli.", "http://cdn.pastemagazine.com/www/articles/ItKing.jpg", 1986, "x11112", "It" },
                    { 3, "Shirley Jackson", 1, "No live organism can continue for long to exist sanely under conditions of absolute reality; even larks and katydids are supposed, by some, to dream. Hill House, not sane, stood by itself against the hills, holding darkness within; it had stood so for eighty years and might stand for eighty more.", "http://cdn.pastemagazine.com/www/articles/HauntingofHillHouseJackson.jpg", 1986, "x11113", "The Haunting of Hill House" },
                    { 4, "Ian Flemming", 2, "Casino Royale is the first novel by the British author Ian Fleming. Published in 1953, it is the first James Bond book, and it paved the way for a further eleven novels and two short story collections by Fleming, followed by numerous continuation Bond novels by other authors. ", "https://upload.wikimedia.org/wikipedia/en/a/a9/CasinoRoyaleCover.jpg", 1953, "x11114", "Casino Royale" },
                    { 5, "Luke Jennings", 2, "Killing Eve: Die for Me is a 2020 thriller novel by British author Luke Jennings. It is the third and final installment in the Killing Eve series, following Codename Villanelle (2017) and Killing Eve: No Tomorrow (2018).[1] The novel was published in the United Kingdom by John Murray as an e-book on 9 April 2020,[2] followed by hardcover and paperback versions on 11 June and 12 November 2020, respectively.[3][4] The novels are the basis of the BBC America television series Killing Eve (2018–2022).", "https://upload.wikimedia.org/wikipedia/en/9/91/Killing_Eve_Die_for_Me_book_cover.png", 2020, "x11115", "Killing Eve: Die for Me" },
                    { 6, "Ernest Cline", 2, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 2011, "x11116", "Ready Player One" },
                    { 7, "C.S. Lewis", 3, "The Lion, the Witch and the Wardrobe is a fantasy novel for children by C. S. Lewis, published by Geoffrey Bles in 1950. It is the first published and best known of seven novels in The Chronicles of Narnia (1950–1956). Among all the author's books, it is also the most widely held in libraries.[2] Although it was originally the first of The Chronicles of Narnia, it is volume two in recent editions that are sequenced by the stories' chronology. Like the other Chronicles, it was illustrated by Pauline Baynes, and her work has been retained in many later editions.", "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg", 1950, "x11117", "The Lion, the Witch and the Wardrobe" },
                    { 8, "Ken Liu", 3, "Complex, ambitious, and drop-dead gorgeous, the first book in Ken Liu’s Dandelion Dynasty series is an intricately plotted fantasy epic. Former enemies become allies to overturn an ancient empire, rendered in beautiful prose that showcases Liu’s “silkpunk” style—East Asian-inspired cultures alongside fantastical technology like airships and battle kites.", "https://static.wikia.nocookie.net/the-dandelion-dynasty/images/8/8f/18952341.jpg/revision/latest/scale-to-width-down/314?cb=20170130212114", 1978, "x11118", "The Grace of Kings" },
                    { 9, "Scott Hawkins", 3, "Carolyn and her eleven siblings live together in the house of their father, a seemingly immortal man whose library grants them special powers. To say anything else would spoil this riveting, one-of-a-kind novel full of surprises and paced like a thriller.", "https://upload.wikimedia.org/wikipedia/en/9/94/The_Library_At_Mount_Char_book_cover.jpg", 2015, "x11119", "The Library at Mount Char" },
                    { 10, "Sally Roney", 4, "This quiet love story centers around Alice, Felix, Eileen and Simon — four people trying to find their way in the world. Romantic entanglement ensues (this is a Rooney novel, after all) and you'll find your own allegiances shifting and changing as you read.", "https://upload.wikimedia.org/wikipedia/en/3/31/Beautiful_World%2C_Where_Are_You_-_1st_UK_edition_cover.jpg", 2021, "x11120", "Beautiful World, Where Are You" },
                    { 11, "Sally Roney", 4, "Twenty years ago, Eva and Shane fell in love over a whirlwind of a week. When they happen to reconnect in Brooklyn, Eva (now an erotica writer) and Shane (now a bestselling author) have a chance at closure, or rekindling the spark that brought them together in the first place. It's sexy, sultry and deliciously steamy.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1621846249l/55648820._SY475_.jpg", 2021, "x11121", "Seven Days in June" },
                    { 12, "Andre Aciman", 4, "This quiet love story centers around Alice, Felix, Eileen and Simon — four people trying to find their way in the world. Romantic entanglement ensues (this is a Rooney novel, after all) and you'll find your own allegiances shifting and changing as you read.", "https://upload.wikimedia.org/wikipedia/en/c/c9/CallMeByYourName2017.png", 2007, "x11122", "Call Me by Your Name" },
                    { 13, "Walter Isaacson", 5, "The man, the myth, the legend: Steve Jobs, co-founder and CEO of Apple, is properly immortalized in Isaacson’s masterful biography. It divulges the details of Jobs’ little-known childhood and tracks his fateful path from garage engineer to leader of one of the largest tech companies in the world", "https://upload.wikimedia.org/wikipedia/en/e/e4/Steve_Jobs_by_Walter_Isaacson.jpg", 2011, "x11123", "Steve Jobs" },
                    { 14, "Evelyn C. White", 5, "Alice Walker has given us some of the most celebrated and beloved books, including The Color Purple, which made her the first Black woman to win a Pulitzer Prize. In this comprehensive biography, Evelyn C. White conducts extensive research and numerous interviews and draws connections between Walker’s early life events, societal ills, and the brilliant writer that Walker would become. ", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348816682l/60936.jpg", 2004, "x11124", "Alice Walker: A Life" },
                    { 15, "Sally Bedell Smith", 5, "If you can’t get enough of The Crown on Netflix, this biography will be your cup of tea. This is author Sally Bedell Smith’s third biography of a member of the royal family, and her expertise in making connections and presenting research shines.", "https://upload.wikimedia.org/wikipedia/commons/2/2d/Queen_Elizabeth_the_Queen_Mother_portrait.jpg", 2012, "x11125", "Elizabeth the Queen: The Life of a Modern Monarch" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Phone_Number" },
                values: new object[,]
                {
                    { 1, "Lyckogatan 23", "oliver@rodin.com", "Oliver Rodin", "070-3425467" },
                    { 2, "Bergsvägen 32", "anna@andersson.com", "Anna Andersson", "070-0985467" },
                    { 3, "Apparatgatan 1", "fredrik@fredriksson.com", "Fredrik Fredriksson", "070-3400067" },
                    { 4, "Alftavägen 20", "annika@lantz.com", "Annika Lantz", "070-3420107" },
                    { 5, "Hjulgatan 45", "jessica@andersson.com", "Jessica Andersson", "070-3420000" },
                    { 6, "Skogsgatan 100", "magnus@dixon.com", "Magnus Dixon", "070-3421111" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveBorrows_BookId",
                table: "ActiveBorrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveBorrows_CustomerId",
                table: "ActiveBorrows",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedBorrows_BookId",
                table: "ReturnedBorrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnedBorrows_CustomerId",
                table: "ReturnedBorrows",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveBorrows");

            migrationBuilder.DropTable(
                name: "ReturnedBorrows");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
