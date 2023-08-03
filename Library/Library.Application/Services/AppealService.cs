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
}