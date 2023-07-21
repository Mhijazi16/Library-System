using Action = Library.Domain.Common.Transaction.Value_Object.Action;

namespace Library.Domain.LibrarianPanel.Value_Object;
using Book.Aggregate;
using Patrion.Aggregate;

public record Appeal
{
    public Guid AppealId { get; init; }
    public Guid PatrionId { get; init; }
    public Guid BookId { get; init; }

    private Appeal(){}

    public Appeal(Guid patrion, Guid book)
    {
        AppealId = Guid.NewGuid();
        PatrionId = patrion;
        BookId = book;
    }
}