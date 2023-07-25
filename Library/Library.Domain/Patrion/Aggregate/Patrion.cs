using System.Net.Mail;
using System.Transactions;
using Library.Domain.Patrion.Value_Object;

namespace Library.Domain.Patrion.Aggregate;
using Book.Aggregate;
using Common.Transaction.Aggregate;

public class Patrion
{
    public string FirstName{ get; private set; }
    public string LastName{ get; private set; }
    public string Email { get; private set; }
    private HashSet<BorrowedBook>? _books = null;
    private HashSet<Transaction>? _transactionHistory = null;
    
    //Navigation Properties & Foreign Keys
    public IReadOnlyList<BorrowedBook>? BookSet => _books.ToList();
    public IReadOnlyList<Transaction>? PatrionTransactions => _transactionHistory.ToList();


    private Patrion(){}

    public Patrion(string first,string last, string email)
    {
        FirstName = first;
        LastName = last;
        Email = email;
    }

    public void AddBook(Book book)
    {
        _books ??= new HashSet<BorrowedBook>();
        _books.Add(new BorrowedBook(book));
    }
    public void AddTransaction(Transaction transaction)
    {
        _transactionHistory ??= new HashSet<Transaction>();
        _transactionHistory.Add(transaction);
    }   
}