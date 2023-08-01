using Library.Application.Interfaces;
using Library.Domain.LibrarianPanel.Value_Object;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Services;

public class AppealRepository : GenericRepository<Appeal>
{
    public AppealRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<Appeal?> GetAppealWithBook(Guid Id)
        => await _entity.Include(appeal => appeal.Book)
            .FirstOrDefaultAsync(appeal => appeal.Id == Id);

    public async Task<Appeal?> GetAppealWithPatrion(Guid Id)
        => await _entity.Include(appeal => appeal.Patrion)
            .FirstOrDefaultAsync(appeal => appeal.Id == Id);

    public async Task<Appeal?> GetWholeAppeal(Guid Id)
        => await _entity.Include(appeal => appeal.Book)
            .Include(appeal => appeal.Patrion)
            .FirstOrDefaultAsync(appeal => appeal.Id == Id);
}