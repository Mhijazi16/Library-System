using Library.Application.Interfaces;
using Library.Domain.Book.Aggregate;
using Library.Domain.Book.Enums;
using Library.Domain.LibrarianPanel.Value_Object;
using Library.Domain.Patrion.Aggregate;

namespace Library.Application.Services;

public class BorrowService
{
    private readonly IAppealRepository _appealRepository;
    private readonly IRepository<Book> _bookRepository;
    private Patrion Patrion { get; set; }

    public BorrowService(IAppealRepository appealRepository,IRepository<Book> bookRepository)
    {
        _appealRepository = appealRepository;
        _bookRepository = bookRepository;
    }

    public void ManagePatrion(Patrion patrion)
        => Patrion = patrion; 

    public async Task<Appeal> BorrowAsync(Guid bookId)
    {
        var book = await _bookRepository.GetEntityByIdAsync(bookId);
        if (book?.Status != Status.Available)
        {
            throw new ArgumentException($"Book With Id:{bookId} is Already Borrowed");
        }
        
        book.ChangeStatus(Status.Pending);

        var appeal = new Appeal(Patrion.Id, bookId,AppealType.Borrow);

        await _appealRepository.AddAsync(appeal);
        await _appealRepository.SaveAsync();

        return appeal;
    }

    public async Task<Appeal> BorrowAsync(Book book)
    {
        if (book.Status != Status.Available)
        {
            throw new ArgumentException($"Book With Id:{book.Id} is Already Borrowed");
        }
        
        book.ChangeStatus(Status.Pending);

        var appeal = new Appeal(Patrion.Id, book.Id,AppealType.Borrow);
        
        await _appealRepository.AddAsync(appeal);
        await _appealRepository.SaveAsync();

        return appeal;
    }
    
    public async Task<Appeal> ReturnAsync(Appeal appeal)
    {
        var book = appeal.Book; 
        if (book?.Status != Status.Borrowed)
        {
            throw new ArgumentException($"Book With Id:{book.Id} Can not be returned since it's not Borrowed");
        }
        
        book.ChangeStatus(Status.Pending);
        Patrion.RemoveBook(book);
         
        appeal = new Appeal(Patrion.Id, appeal.BookId, AppealType.Return);

        await _appealRepository.AddAsync(appeal);
        await _appealRepository.SaveAsync();
        
        return appeal;
    }
}