namespace Library.Domain.Common.Transaction;
using Value_Object;
using Patrion.Aggregate;
using Aggregate;


public record BookTransaction : Transaction
{
    public Patrion Patrion { get; init; } 
    public BookTransaction(TransactionType type,TransactionStatus status, Patrion patrion) : base(type,status)
    {
        this.Patrion = patrion;
    }
}