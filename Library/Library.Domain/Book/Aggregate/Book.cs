using Library.Domain.Book.Entities;
using Library.Domain.Book.Enums;
using Library.Domain.Book.Value_Object;
using Library.Domain.Common.Transaction.Aggregate;

namespace Library.Domain.Book.Aggregate;

public class Book
{

   public Guid Id { get; private set; }
   public string Title { get; set; } 
   public string Description { get; set; }
   public Genre Genre { get; set; }
   public Status Status { get; internal set; } = Status.Available;
    
   //Navigation Properties & Foreign Keys  
   public Guid AuthorId { get; private set; }
   public HashSet<Transaction> BookTransactions { get; private set; } = new HashSet<Transaction>();
   public List<Review>? BookReviews { get; private set; } = new List<Review>() ;

   public Book(){}

   public static Book Create(string title,string description, Genre genre)
   {
       return new Book
       {
           Id = Guid.NewGuid(),
           Title = title,
           Description = description,
           Genre = genre,
       };
   }

   public void AddAuthor(Guid authorId)
       => AuthorId = authorId; 
   
   public void AddTransaction(Transaction transaction)
       => BookTransactions.Add(transaction);

   public void RemoveTransaction(Transaction transaction)
       => BookTransactions?.Remove(transaction);

   public void AddReview(Review review)
       => BookReviews?.Add(review);

   public void RemoveReview(Review review)
       => BookReviews?.Remove(review);

   public void ChangeStatus(Status status)
       => Status = status;
}