namespace Library.Domain.Common.Transaction;
using Value_Object;
using Patrion.Aggregate;
using Aggregate;


public record BookTransaction : Transaction
{
    public Patrion Patrion { get; init; } 
    public BookTransaction(TransactionType type, Patrion patrion) : base(type)
    {
        this.Patrion = patrion;
    }
}