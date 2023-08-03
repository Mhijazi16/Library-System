namespace Library.Domain.Common.Transaction.Aggregate;

using Library.Domain.Book.Value_Object;
using Value_Object;
using Book.Aggregate;   
using Patrion.Aggregate;

public record Transaction 
{
    public Guid Id { get; init; }
    public BorrowSpan? Span { get; init; } = null; 
    public Action TransactionType { get; init; }
    
    //Navigation Properties
    public Guid PatrionId { get; init; }
    public Patrion Patrion { get; init; }
    public Guid BookId { get; init; }
    public Book Book { get; init; }
    public State State { get; init; }
     
    private Transaction(){}
    public Transaction(Action transactionType,Guid patrionId,Guid bookId, State state)
    {
        Id = Guid.NewGuid();
        PatrionId = patrionId;
        BookId = bookId;
        TransactionType = transactionType;
        State = state;

        if (transactionType == Action.Borrow && State == State.Success) 
        {
            Span = new BorrowSpan
            {
                IssueDate = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddMinutes(2),
            };
        }
        

    }
}