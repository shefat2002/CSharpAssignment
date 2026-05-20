using System.Collections;
using Project1B;

namespace Project1C;

public class ITBookCollection<T> : IEnumerable<T> where T : ITBook
{
    private List<T> _books = new();

    public void Add(T book)
    {
        _books.Add(book);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var book in _books)
        {
            yield return book;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}