namespace Library.Domain.Common.Transaction.Aggregate;

using Library.Domain.Book.Value_Object;
using Value_Object;
using Book.Aggregate;   
using Patrion.Aggregate;

public record Transaction 
{
    public Guid Id { get; init; }
    public BorrowSpan? Span { get; init; } = null; 
    public Action Type { get; init; }
    public State Status { get; init; }
    
    //Navigation Properties
    public Guid PatrionId { get; init; }
    public Patrion Patrion { get; init; }
    public Guid BookId { get; init; }
    public Book Book { get; init; }
     
    private Transaction(){}
    public Transaction(Action type,State status,Guid patrionId,Guid bookId)
    {
        Id = Guid.NewGuid();
        PatrionId = patrionId;
        BookId = bookId;
        Type = type;
        Status = status;

        if (type is Action.Borrow && status is State.Success)
        {
            Span = new BorrowSpan
            {
                IssueDate = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddMinutes(2),
            };
        }
        

    }
}