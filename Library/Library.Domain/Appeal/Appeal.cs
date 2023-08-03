
namespace Library.Domain.LibrarianPanel.Value_Object;
using Book.Aggregate;
using Patrion.Aggregate;

public record Appeal
{
    public Guid Id { get; init; }
    public Guid PatrionId { get; init; }
    public Guid BookId { get; init; }
    public Book Book { get; init; }
    public Patrion Patrion { get; init; }
    public AppealType Type { get; init; }

    private Appeal(){}

    public Appeal(Guid patrion, Guid book,AppealType type)
    {
        Id = Guid.NewGuid();
        PatrionId = patrion;
        BookId = book;
        Type = type;
    }
}