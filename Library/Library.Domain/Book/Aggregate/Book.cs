using Library.Domain.Book.Entities;
using Library.Domain.Book.Enums;
using Library.Domain.Book.Value_Object;
using Library.Domain.Common.Transaction;

namespace Library.Domain.Book.Aggregate;

public class Book
{
   public String Title { get; set; } 
   public Genre Genre { get; set; }
   public Status Status { get; internal set; } = Status.Available;
   public Author Author { get; internal set; }
   public HashSet<BookTransaction>? TransactionHistory { get; internal set; } = null;
   public List<Review>? BookReviews { get; internal set; } = null;
   
   private Book(){}

   public static Book Create(String title, Genre genre, Author author)
   {
       return new Book
       {
           Title = title,
           Genre = genre,
           Author = author,
       };
   }
}