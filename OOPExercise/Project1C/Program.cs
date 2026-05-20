using Project1B;
using Project1C;
using Type = Project1B.Type;

ITBook book1 = new ITBook
{
    Id = 1,
    Title = "C#",
    Price = 39.99m,
    Type = Type.Print,
    Publisher = "Manning",
    PublishDate = new DateTime(2023, 1, 1)
};
book1.Tag.Add(".NET");
book1.Tag.Add("Programming");

ITBook book2 = new ITBook
{
    Id = 2,
    Title = "Java",
    Price = 29.99m,
    Type = Type.Ebook,
    Publisher = "Prentice Hall",
    PublishDate = new DateTime(2022, 5, 15)
};
book2.Tag.Add("Programming");
book2.Tag.Add("Java");

ITBookCollection<ITBook> collection = new ITBookCollection<ITBook>();
collection.Add(book1);
collection.Add(book2);

Console.WriteLine("Testing Collection");
foreach (var book in collection)
{
    Console.WriteLine($"{book.Title} by {string.Join(", ", book.Authors)} - ${book.Price} [{book.Type}]");
}
