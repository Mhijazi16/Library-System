namespace Library.Domain.Patrion.Value_Object;


public record BorrowedBook
{
    public Guid Id { get;  init; }
    public string Title { get; init; } 
    public string Description { get; init; }
    public string Genre { get; init; }
    public string Status { get;  init; } 
     
    private BorrowedBook(){}

    public BorrowedBook(Book.Aggregate.Book book)
    {
        Id = Guid.NewGuid();
        Title = book.Title;
        Description = book.Description;
        Genre = book.Genre.ToString();
        Status = book.Status.ToString();
    }
    
}