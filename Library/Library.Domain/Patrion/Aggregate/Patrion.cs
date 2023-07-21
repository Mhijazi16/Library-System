using System.Net.Mail;
using System.Transactions;

namespace Library.Domain.Patrion.Aggregate;
using Book.Aggregate;
using Common.Transaction.Aggregate;

public class Patrion
{
    public string FirstName{ get; private set; }
    public string LastName{ get; private set; }
    public string Email { get; private set; }
    public HashSet<Book>? Books { get; private set; } = null;
    public HashSet<Transaction>? TransactionHistory { get; private set; } = null;
    
    private Patrion(){}

    public Patrion(string first,string last, string email)
    {
        FirstName = first;
        LastName = last;
        Email = email;
    }

    public void AddBook(Book book)
    {
        if (Books is null)
        {
            Books = new HashSet<Book>();
        }

        Books.Add(book);
    }
    public void AddTransaction(Transaction transaction)
     {
         if (TransactionHistory is null)
         {
             TransactionHistory = new HashSet<Transaction>();
         }

         TransactionHistory.Add(transaction);
     }   
}