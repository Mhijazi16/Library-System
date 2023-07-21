using Library.Domain.Book.Entities;
using Library.Domain.Book.Enums;
using Library.Domain.Book.Value_Object;
using Library.Domain.Common.Transaction;
using Library.Domain.Common.Transaction.Aggregate;

namespace Library.Domain.Book.Aggregate;

public class Book
{
   public Guid Id { get; private set; }
   public Guid AuthorId { get; private set; }
   public String Title { get; set; } 
   public Genre Genre { get; set; }
   public Status Status { get; internal set; } = Status.Available;
   public HashSet<Transaction>? TransactionHistory { get; private set; } = null;
   public List<Review>? BookReviews { get; private set; } = null;
   
   private Book(){}

   public static Book Create(String title, Genre genre, Guid authorId)
   {
       return new Book
       {
           Id = Guid.NewGuid(),
           Title = title,
           Genre = genre,
           AuthorId = authorId, 
       };
   }

   public void AddTransaction(Transaction transaction)
   {
       if (TransactionHistory is null)
       {
           TransactionHistory = new HashSet<Transaction>();
       }

       TransactionHistory.Add(transaction);
   }

   public void AddReview(Review review)
   {
       if (BookReviews is null)
       {
           BookReviews = new List<Review>();
       }
       
       BookReviews.Add(review);
   }
}