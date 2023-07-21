namespace Library.Domain.Common.Transaction;
using Value_Object;
using Book .Aggregate;
using Aggregate;


public record PatrionTransaction : Transaction
{
    public Book Book{ get; init; } 
    public PatrionTransaction(TransactionType type,TransactionStatus status, Book  book) : base(type,status)
    {
        this.Book  = book;
    }
}