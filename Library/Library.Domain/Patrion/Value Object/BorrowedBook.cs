namespace Library.Domain.Patrion.Value_Object;
using Book.Enums;


public record BorrowedBook
{
    public Guid Id { get;  init; }
    public string Title { get; init; } 
    public string Description { get; init; }
    public Genre Genre { get; init; }
    public Status Status { get;  init; } 
     
    private BorrowedBook(){}

    public BorrowedBook(Book.Aggregate.Book book)
    {
        Id = book.Id;
        Title = book.Title;
        Description = book.Description;
        Genre = book.Genre;
        Status = book.Status;
    }
    
}