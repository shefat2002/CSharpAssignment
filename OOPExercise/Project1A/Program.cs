using Project1A;

Book[] books = new Book[5];

books[0] = new ITBook(1, "C# in Depth", 39.99m, BookType.Print, "Manning", new(2023, 1, 1), CompareBy.Title,
    new List<string> { "Programming", "C#" }, "A comprehensive guide to C# programming");
books[0].SetAuthor("Jon Skeet");
((ITBook)books[0]).SetTag(".NET");

books[1] = new ITBook(2, "Clean Code", 29.99m, BookType.Ebook, "Prentice Hall", new(2022, 5, 15), CompareBy.Price,
    new List<string> { "Software Engineering" }, "A handbook of agile software craftsmanship");
books[1].SetAuthor("Robert C. Martin");

books[2] = new ITBook(3, "Design Patterns", 49.99m, BookType.Print, "Addison-Wesley", new(2021, 3, 10), CompareBy.Title,
    new List<string> { "Design", "Patterns" }, "Elements of reusable object-oriented software");
books[2].SetAuthor("Erich Gamma");
books[2].SetAuthor("Richard Helm");
books[2].SetAuthor("Ralph Johnson");
books[2].SetAuthor("John Vlissides");

books[3] = new ITBook(4, "Refactoring", 35.50m, BookType.Ebook, "Addison-Wesley", new(2020, 8, 20), CompareBy.Title,
    new List<string> { "Refactoring" }, "Improving the design of existing code");
books[3].SetAuthor("Martin Fowler");

books[4] = new ITBook(5, "The Pragmatic Programmer", 42.00m, BookType.Print, "Addison-Wesley", new(2019, 11, 5), CompareBy.Price,
    new List<string> { "Programming" }, "Your journey to mastery");
books[4].SetAuthor("David Thomas");
books[4].SetAuthor("Andrew Hunt");

Console.WriteLine("=== Original Order ===");
DisplayBooks(books);

Array.Sort(books);

Console.WriteLine("\n=== Sorted by Title/Price ===");
DisplayBooks(books);

void DisplayBooks(Book[] bookArray)
{
    for (int i = 0; i < bookArray.Length; i++)
    {
        var book = (ITBook)bookArray[i];
        Console.WriteLine($"{i + 1}. {book.Title} by {string.Join(", ", book.GetAuthor())} - ${book.Price} [{book.Type}]");
    }
}

Console.WriteLine("\n=== Linq Queries ===");

var query1 = from book in books
             where book.Price > 30
             select book;
