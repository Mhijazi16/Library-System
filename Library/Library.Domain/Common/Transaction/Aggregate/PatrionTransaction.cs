namespace Library.Domain.Common.Transaction;
using Value_Object;
using Book .Aggregate;
using Aggregate;


public record PatrionTransaction : Transaction
{
    public Book Book{ get; init; } 
    public PatrionTransaction(TransactionType type, Book  book) : base(type)
    {
        this.Book  = book;
    }
}