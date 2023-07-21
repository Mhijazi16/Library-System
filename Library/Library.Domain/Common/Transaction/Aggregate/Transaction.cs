namespace Library.Domain.Common.Transaction.Aggregate;

using Library.Domain.Book.Value_Object;
using Value_Object;

public record Transaction 
{
    public Guid Id { get; init; }
    public BorrowSpan? Span { get; init; } = null; 
    public TransactionType Type { get; init; }
    public TransactionStatus Status { get; init; }
    
    private Transaction(){}
    public Transaction(TransactionType type,TransactionStatus status)
    {
        Id = Guid.NewGuid();
        Type = type;
        Status = status;

        if (type is TransactionType.Borrow && status is TransactionStatus.Success)
        {
            Span = new BorrowSpan
            {
                IssueDate = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddMinutes(2),
            };
        }
        

    }
}