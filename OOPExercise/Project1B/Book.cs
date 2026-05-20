namespace Project1B;

public enum Type
{
    Print,
    Ebook
}

public abstract class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public Type Type { get; set; }
    public List<String> Authors = new List<String>();
    public String Publisher { get; set; }
    public DateTime PublishDate { get; set; }
    public List<String> Tag = new List<String>();

    public Book()
    {
        Authors = new List<String>();
        Tag = new List<String>();
    }

    public Book(int id, string title, decimal price, Type type, string publisher, DateTime publishDate)
    {
        Id = id;
        Title = title;
        Price = price;
        Type = type;
        Publisher = publisher;
        PublishDate = publishDate;
    }
 
}

public interface IAuthor<T>
{
    string GetAuthorsCommaSeparated(IEnumerable<T> authors);
}

public interface ITag<T>
{
    string GetTagsCommaSeparated(IEnumerable<T> tags);
}

public class ITBook : Book, IAuthor<string>, ITag<string>
{
    public ITBook() : base()
    {
        
    }
    
    public ITBook(int id, string title, decimal price, Type type, string publisher, DateTime publishDate) : base(id, title, price, type, publisher, publishDate)
    {
        
    }
    
    public string GetAuthorsCommaSeparated(IEnumerable<string>? authors)
    {
        if(authors == null || !authors.Any()) return string.Empty;
        return string.Join(", ", authors);
    }

    public string GetTagsCommaSeparated(IEnumerable<string>? tags)
    {
        if(tags == null || !tags.Any()) return string.Empty;
        return string.Join(", ", tags);
    }
    
    
}
