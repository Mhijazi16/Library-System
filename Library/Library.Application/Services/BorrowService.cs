using Library.Application.Interfaces;
using Library.Domain.Book.Aggregate;
using Library.Domain.Book.Enums;
using Library.Domain.LibrarianPanel.Value_Object;
using Library.Domain.Patrion.Aggregate;

namespace Library.Application.Services;

public class BorrowService
{
    private readonly IRepository<Book> _bookRepository;
    private readonly IRepository<Appeal> _appealRepository;
    private Patrion Patrion { get; set; }

    public BorrowService
        (IRepository<Book> bookRepo,IRepository<Appeal> appealRepo,Patrion patrion)
    {
        Patrion = patrion;
        _bookRepository = bookRepo;
        _appealRepository = appealRepo;
    }
 
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
        _bookRepository.UpdateAsync(book);
        await _bookRepository.SaveAsync();

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
        _bookRepository.UpdateAsync(book);
        await _bookRepository.SaveAsync();

        return appeal;
    }
}