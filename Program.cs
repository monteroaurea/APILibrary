using APILibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ILibraryRepository, DbRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseMySql(mySqlConnection,
    ServerVersion.AutoDetect(mySqlConnection)));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();

namespace APILibrary
{
    class Program
    {
        static IEnumerable<Author> LibraryBooks()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    Name = "J. R. R. Tolkien", Books = new List<Book>
                    {
                        new Book {Title="The Hobbit"},
                        new Book {Title="The Lord of the Rings: The Fellowship of the Ring"},
                        new Book {Title="The Lord of the Rings: The Two Towers"},
                        new Book {Title="The Lord of the Rings: The Return of the King"}
                    }
                },

                new Author
                {
                    Name ="C. S. Lewis", Books = new List<Book>
                    {
                        new Book {Title="The Chronicles of Narnia: The Lion, the Witch and the Wardrobe"},
                        new Book {Title="The Chronicles of Narnia: Prince Caspian"},
                        new Book {Title="The Chronicles of Narnia: The Voyage of the Dawn Treader "},
                        new Book {Title="The Chronicles of Narnia: The Silver Chair"},
                        new Book {Title="The Chronicles of Narnia: The Horse and His Boy"},
                        new Book {Title="The Chronicles of Narnia: The Last Battle"}
                    }

                },

                new Author
                {
                    Name ="George Orwell", Books = new List<Book>
                    {
                        new Book {Title="1984"},
                        new Book {Title="Animal Farm"}

                    }
                },

                new Author
                {
                    Name ="Cornelia Funke", Books = new List<Book>
                    {
                        new Book {Title="Inkheart"},
                        new Book {Title="Inkspell"},
                        new Book {Title="Inkdeath"}
                    }
                },
            };
            return authors;
        }
        static void Main()
        {

            using var db = new LibraryContext(Options);

            db.Database.EnsureCreated

            var authors = LibraryBooks();

            foreach (var author in authors)
            {
                Console.WriteLine($"{author} wrote...");

                foreach (var book in author.Books)
                    Console.WriteLine($"   {book}");

                Console.WriteLine();
            }
        }

    }

}