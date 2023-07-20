namespace Library.Domain.Patrion.Aggregate;
using Book.Aggregate;
using Common.Transaction;

public class Patrion
{
    public HashSet<Book>? Books { get; private set; } = null;
    public HashSet<PatrionTransaction>? Transactions { get; private set; } = null;
}