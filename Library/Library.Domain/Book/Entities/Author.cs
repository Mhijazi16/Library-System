namespace Library.Domain.Book.Entities;
using Library.Domain.Book.Aggregate;

public class Author
{
    public string Name { get; private set; }
    public List<Book>? Books { get; private set; } = null;
}