using Library.Application.Interfaces;
using Library.Domain.Book.Enums;
using Library.Domain.Common.Transaction.Aggregate;
using Library.Domain.Common.Transaction.Value_Object;
using Library.Domain.LibrarianPanel.Value_Object;
using Action = Library.Domain.Common.Transaction.Value_Object.Action;

namespace Library.Application.Services;

public class AppealService
{
   private readonly IAppealRepository _appealRepository;
   private readonly IRepository<Transaction> _transactionsRepository;

   public AppealService
      (IAppealRepository appealRepository,IRepository<Transaction> transactionRepository)
   {
      _appealRepository = appealRepository;
      _transactionsRepository = transactionRepository;
   }

   public async Task<Transaction> AcceptBorrowAppeal(Appeal appeal)
   {
      var book = appeal.Book;
      var patrion = appeal.Patrion;
      var transaction = new Transaction
         (Action.Borrow, appeal.PatrionId, appeal.BookId,State.Success);
      
      book.ChangeStatus(Status.Borrowed);
      patrion.AddBook(book);
      book.AddTransaction(transaction);
      patrion.AddTransaction(transaction);

      _appealRepository.UpdateAsync(appeal);
      await _transactionsRepository.AddAsync(transaction);
      await _appealRepository.SaveAsync();
      _appealRepository.DeleteEntity(appeal);
      await _appealRepository.SaveAsync();

      return transaction;
   }

   public async Task<Transaction> AcceptBorrowAppeal(Guid Id)
   {
      var appeal = await _appealRepository.GetWholeAppeal(Id);
      var book = appeal?.Book;
      var patrion = appeal?.Patrion;
      var transaction = new Transaction
         (Action.Borrow, patrion.Id, book.Id,State.Success);
      
      book.ChangeStatus(Status.Borrowed);
      patrion.AddBook(book);
      book.AddTransaction(transaction);
      patrion.AddTransaction(transaction);

      _appealRepository.UpdateAsync(appeal);
      await _transactionsRepository.AddAsync(transaction);
      await _appealRepository.SaveAsync();
      _appealRepository.DeleteEntity(appeal);
      await _appealRepository.SaveAsync();
      

      return transaction;
   }
   
}