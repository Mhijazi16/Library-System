using Library.Domain.Book.Entities;
using Library.Domain.Book.Enums;
using Library.Domain.Book.Value_Object;
using Library.Domain.Common.Transaction.Aggregate;

namespace Library.Domain.Book.Aggregate;

public class Book
{

   public Guid Id { get; private set; }
   public String Title { get; set; } 
   public String Description { get; set; }
   public Genre Genre { get; set; }
   public Status Status { get; internal set; } = Status.Available;
   private HashSet<Transaction>? _transactionHistory  = null;
   private List<Review>? _bookReviews = null;
    
   //Navigation Properties & Foreign Keys  
   public Guid AuthorId { get; private set; }
   public IReadOnlyList<Transaction>? BookTransactions => _transactionHistory.ToList(); 
   public IReadOnlyList<Review>? BookReviews => _bookReviews.ToList(); 

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
       _transactionHistory ??= new HashSet<Transaction>();

       _transactionHistory.Add(transaction);
   }

   public void AddReview(Review review)
   {
       _bookReviews ??= new List<Review>();

       _bookReviews.Add(review);
   }
}