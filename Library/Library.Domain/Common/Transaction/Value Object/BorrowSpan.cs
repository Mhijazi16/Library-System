namespace Library.Domain.Book.Value_Object;

public record BorrowSpan
{
    public BorrowSpan()
    {
    }

    public DateTime IssueDate { get; init; }
    public DateTime DueDate { get; init; }
}