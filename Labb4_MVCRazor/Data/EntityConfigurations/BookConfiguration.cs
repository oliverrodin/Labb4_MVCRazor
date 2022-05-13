using Labb4_MVCRazor.Data.Enums;
using Labb4_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labb4_MVCRazor.Data.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();

            builder.Property(b => b.Title).HasMaxLength(50);
            builder.Property(b => b.Description).HasMaxLength(2000);

            builder.HasData(
                new List<Book>
                {
                    new Book
                    {
                        Id = 1,
                        Title = "Let The Right One in",
                        Description =
                            "If fiction’s taught us anything in recent years, it’s that the vampire genre can be a tired—and ironically toothless—one. But Swedish writer John Ajvide Lindqvist breathed new life into the eternally overdone tale with his debut novel, Let the Right One In, which tells the story of a bullied grade-school student named Oskar and his new friend and neighbor, Eli.",
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/en/b/bf/Lettherightoneinswedishbookcover.jpg",
                        BookCategory = BookCategory.Horror,
                        Author = "John Ajvide Lindqvist",
                        Published = 2004,
                        SerialNumber = "x11111"
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "It",
                        Description =
                            "If fiction’s taught us anything in recent years, it’s that the vampire genre can be a tired—and ironically toothless—one. But Swedish writer John Ajvide Lindqvist breathed new life into the eternally overdone tale with his debut novel, Let the Right One In, which tells the story of a bullied grade-school student named Oskar and his new friend and neighbor, Eli.",
                        ImageUrl = "http://cdn.pastemagazine.com/www/articles/ItKing.jpg",
                        BookCategory = BookCategory.Horror,
                        Author = "Stephen King",
                        Published = 1986,
                        SerialNumber = "x11112"
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "The Haunting of Hill House",
                        Description =
                            "No live organism can continue for long to exist sanely under conditions of absolute reality; even larks and katydids are supposed, by some, to dream. Hill House, not sane, stood by itself against the hills, holding darkness within; it had stood so for eighty years and might stand for eighty more.",
                        ImageUrl = "http://cdn.pastemagazine.com/www/articles/HauntingofHillHouseJackson.jpg",
                        BookCategory = BookCategory.Horror,
                        Author = "Shirley Jackson",
                        Published = 1986,
                        SerialNumber = "x11113"
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "Casino Royale",
                        Description =
                            "Casino Royale is the first novel by the British author Ian Fleming. Published in 1953, it is the first James Bond book, and it paved the way for a further eleven novels and two short story collections by Fleming, followed by numerous continuation Bond novels by other authors. ",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/CasinoRoyaleCover.jpg",
                        BookCategory = BookCategory.Action,
                        Author = "Ian Flemming",
                        Published = 1953,
                        SerialNumber = "x11114"
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "Killing Eve: Die for Me",
                        Description =
                            "Killing Eve: Die for Me is a 2020 thriller novel by British author Luke Jennings. It is the third and final installment in the Killing Eve series, following Codename Villanelle (2017) and Killing Eve: No Tomorrow (2018).[1] The novel was published in the United Kingdom by John Murray as an e-book on 9 April 2020,[2] followed by hardcover and paperback versions on 11 June and 12 November 2020, respectively.[3][4] The novels are the basis of the BBC America television series Killing Eve (2018–2022).",
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/en/9/91/Killing_Eve_Die_for_Me_book_cover.png",
                        BookCategory = BookCategory.Action,
                        Author = "Luke Jennings",
                        Published = 2020,
                        SerialNumber = "x11115"
                    },
                    new Book
                    {
                        Id = 6,
                        Title = "Ready Player One",
                        Description =
                            "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                        BookCategory = BookCategory.Action,
                        Author = "Ernest Cline",
                        Published = 2011,
                        SerialNumber = "x11116"
                    },
                    new Book
                    {
                        Id = 7,
                        Title = "The Lion, the Witch and the Wardrobe",
                        Description =
                            "The Lion, the Witch and the Wardrobe is a fantasy novel for children by C. S. Lewis, published by Geoffrey Bles in 1950. It is the first published and best known of seven novels in The Chronicles of Narnia (1950–1956). Among all the author's books, it is also the most widely held in libraries.[2] Although it was originally the first of The Chronicles of Narnia, it is volume two in recent editions that are sequenced by the stories' chronology. Like the other Chronicles, it was illustrated by Pauline Baynes, and her work has been retained in many later editions.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/86/TheLionWitchWardrobe%281stEd%29.jpg",
                        BookCategory = BookCategory.Fantasy,
                        Author = "C.S. Lewis",
                        Published = 1950,
                        SerialNumber = "x11117"
                    },
                    new Book
                    {
                        Id = 8,
                        Title = "The Grace of Kings",
                        Description =
                            "Complex, ambitious, and drop-dead gorgeous, the first book in Ken Liu’s Dandelion Dynasty series is an intricately plotted fantasy epic. Former enemies become allies to overturn an ancient empire, rendered in beautiful prose that showcases Liu’s “silkpunk” style—East Asian-inspired cultures alongside fantastical technology like airships and battle kites.",
                        ImageUrl =
                            "https://static.wikia.nocookie.net/the-dandelion-dynasty/images/8/8f/18952341.jpg/revision/latest/scale-to-width-down/314?cb=20170130212114",
                        BookCategory = BookCategory.Fantasy,
                        Author = "Ken Liu",
                        Published = 1978,
                        SerialNumber = "x11118"
                    },
                    new Book
                    {
                        Id = 9,
                        Title = "The Library at Mount Char",
                        Description =
                            "Carolyn and her eleven siblings live together in the house of their father, a seemingly immortal man whose library grants them special powers. To say anything else would spoil this riveting, one-of-a-kind novel full of surprises and paced like a thriller.",
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/en/9/94/The_Library_At_Mount_Char_book_cover.jpg",
                        BookCategory = BookCategory.Fantasy,
                        Author = "Scott Hawkins",
                        Published = 2015,
                        SerialNumber = "x11119"
                    },
                    new Book
                    {
                        Id = 10,
                        Title = "Beautiful World, Where Are You",
                        Description =
                            "This quiet love story centers around Alice, Felix, Eileen and Simon — four people trying to find their way in the world. Romantic entanglement ensues (this is a Rooney novel, after all) and you'll find your own allegiances shifting and changing as you read.",
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/en/3/31/Beautiful_World%2C_Where_Are_You_-_1st_UK_edition_cover.jpg",
                        BookCategory = BookCategory.Romance,
                        Author = "Sally Roney",
                        Published = 2021,
                        SerialNumber = "x11120"
                    },
                    new Book
                    {
                        Id = 11,
                        Title = "Seven Days in June",
                        Description =
                            "Twenty years ago, Eva and Shane fell in love over a whirlwind of a week. When they happen to reconnect in Brooklyn, Eva (now an erotica writer) and Shane (now a bestselling author) have a chance at closure, or rekindling the spark that brought them together in the first place. It's sexy, sultry and deliciously steamy.",
                        ImageUrl =
                            "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1621846249l/55648820._SY475_.jpg",
                        BookCategory = BookCategory.Romance,
                        Author = "Sally Roney",
                        Published = 2021,
                        SerialNumber = "x11121"
                    },
                    new Book
                    {
                        Id = 12,
                        Title = "Call Me by Your Name",
                        Description =
                            "This quiet love story centers around Alice, Felix, Eileen and Simon — four people trying to find their way in the world. Romantic entanglement ensues (this is a Rooney novel, after all) and you'll find your own allegiances shifting and changing as you read.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c9/CallMeByYourName2017.png",
                        BookCategory = BookCategory.Romance,
                        Author = "Andre Aciman",
                        Published = 2007,
                        SerialNumber = "x11122"
                    },
                    new Book
                    {
                        Id = 13,
                        Title = "Steve Jobs",
                        Description =
                            "The man, the myth, the legend: Steve Jobs, co-founder and CEO of Apple, is properly immortalized in Isaacson’s masterful biography. It divulges the details of Jobs’ little-known childhood and tracks his fateful path from garage engineer to leader of one of the largest tech companies in the world",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e4/Steve_Jobs_by_Walter_Isaacson.jpg",
                        BookCategory = BookCategory.Biography,
                        Author = "Walter Isaacson",
                        Published = 2011,
                        SerialNumber = "x11123"
                    },
                    new Book
                    {
                        Id = 14,
                        Title = "Alice Walker: A Life",
                        Description =
                            "Alice Walker has given us some of the most celebrated and beloved books, including The Color Purple, which made her the first Black woman to win a Pulitzer Prize. In this comprehensive biography, Evelyn C. White conducts extensive research and numerous interviews and draws connections between Walker’s early life events, societal ills, and the brilliant writer that Walker would become. ",
                        ImageUrl =
                            "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348816682l/60936.jpg",
                        BookCategory = BookCategory.Biography,
                        Author = "Evelyn C. White",
                        Published = 2004,
                        SerialNumber = "x11124"
                    },
                    new Book
                    {
                        Id = 15,
                        Title = "Elizabeth the Queen: The Life of a Modern Monarch",
                        Description =
                            "If you can’t get enough of The Crown on Netflix, this biography will be your cup of tea. This is author Sally Bedell Smith’s third biography of a member of the royal family, and her expertise in making connections and presenting research shines.",
                        ImageUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/2/2d/Queen_Elizabeth_the_Queen_Mother_portrait.jpg",
                        BookCategory = BookCategory.Biography,
                        Author = "Sally Bedell Smith",
                        Published = 2012,
                        SerialNumber = "x11125"
                    }
                });

        }
    }

}
