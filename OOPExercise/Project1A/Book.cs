namespace Project1A;

public enum BookType
{
    Print,
    Ebook
}

public enum CompareBy
{
    Title,
    Price
}

public abstract class Book : IAuthor, IComparable<Book>
{
    public int Id { get; set; }
    public string Title { get; }
    public decimal Price { get; }
    public BookType Type { get; }
    public string Publisher { get; }
    public DateTime PublishDate { get; }
    public CompareBy CompareBy { get; }

    private readonly List<string> _authors = new();

    protected Book()
    {
        Title = string.Empty;
        Publisher = string.Empty;
        CompareBy = CompareBy.Title;
        Type = BookType.Print;
    }

    protected Book(int id, string title, decimal price, BookType type, string publisher,
                   DateTime publishDate, CompareBy compareBy)
    {
        Id = id;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Price = price;
        Type = type;
        Publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        PublishDate = publishDate;
        CompareBy = compareBy;
    }

    public void SetAuthor(string author)
    {
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be null or empty.", nameof(author));
        _authors.Add(author);
    }

    public IReadOnlyList<string> GetAuthor() => _authors;

    public int CompareTo(Book? other)
    {
        if (other == null) return 1;
        return CompareBy == CompareBy.Title
            ? string.Compare(Title, other.Title, StringComparison.Ordinal)
            : Price.CompareTo(other.Price);
    }
}

public interface ITag
{
    void SetTag(string tag);
    IReadOnlyList<string> GetTag();
}

public interface IAuthor
{
    void SetAuthor(string author);
    IReadOnlyList<string> GetAuthor();
}

public class ITBook : Book, ITag
{
    public string BriefDescription { get; set; } = string.Empty;

    private readonly List<string> _tags = new();

    public ITBook()
    {
    }

    public ITBook(int id, string title, decimal price, BookType type, string publisher,
                  DateTime publishDate, CompareBy compareBy, List<string>? tags,
                  string? briefDescription)
                  : base(id, title, price, type, publisher, publishDate, compareBy)
    {
        _tags = tags ?? new List<string>();
        BriefDescription = briefDescription ?? string.Empty;
    }

    public void SetTag(string tag)
    {
        if (string.IsNullOrWhiteSpace(tag))
            throw new ArgumentException("Tag cannot be null or empty.", nameof(tag));
        _tags.Add(tag);
    }

    public IReadOnlyList<string> GetTag() => _tags;
}
