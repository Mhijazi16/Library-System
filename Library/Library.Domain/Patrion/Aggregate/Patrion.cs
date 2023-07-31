using System.Net.Mail;
using System.Transactions;
using Library.Domain.Patrion.Value_Object;

namespace Library.Domain.Patrion.Aggregate;
using Book.Aggregate;
using Common.Transaction.Aggregate;

public class Patrion
{
    public Guid Id { get; private set; }
    public string FirstName{ get; private set; }
    public string LastName{ get; private set; }
    public string Email { get; private set; }
    
    //Navigation Properties & Foreign Keys
    public HashSet<BorrowedBook>? BookSet { get; private set; } = new HashSet<BorrowedBook>();
    public HashSet<Transaction>? TransactionHistory { get; private set; } = new HashSet<Transaction>();

    private Patrion(){}

    public Patrion(string first,string last, string email)
    {
        Id = Guid.NewGuid();
        FirstName = first;
        LastName = last;
        Email = email;
    }

    public void AddBook(Book book)
        => BookSet?.Add(new BorrowedBook(book));
    public void RemoveBook(Book book)
        => BookSet?.Remove(new BorrowedBook(book));
    
    public void AddTransaction(Transaction transaction)
        => TransactionHistory?.Add(transaction);
    public void RemoveTransaction(Transaction transaction)
        => TransactionHistory?.Remove(transaction);
}