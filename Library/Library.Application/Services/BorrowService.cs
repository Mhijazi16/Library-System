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
   
}