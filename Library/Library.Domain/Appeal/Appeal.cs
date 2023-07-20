namespace Library.Domain.LibrarianPanel.Value_Object;
using Book.Aggregate;
using Patrion.Aggregate;

public record Appeal
{
    public Guid Id { get; init; }
    public Patrion Patrion { get; init; }
    public Book Book { get; init; }

    private Appeal(){}

    public Appeal(Patrion patrion, Book book)
    {
        Id = Guid.NewGuid();
        Patrion = patrion;
        Book = book;
    }
}