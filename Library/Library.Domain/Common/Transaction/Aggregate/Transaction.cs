namespace Library.Domain.Common.Transaction.Aggregate;

using Library.Domain.Book.Value_Object;
using Value_Object;

public record Transaction 
{
    public Guid Id { get; init; }
    public BorrowSpan? Span { get; init; } = null; 
    public TransactionType Type { get; init; }
    
    private Transaction(){}
    public Transaction(TransactionType type)
    {
        Id = Guid.NewGuid();
        Type = type;

        if (type is TransactionType.Borrow)
        {
            Span = new BorrowSpan
            {
                IssueDate = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddMinutes(2),
            };
        }
        

    }
}