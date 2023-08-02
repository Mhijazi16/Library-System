using Library.Domain.LibrarianPanel.Value_Object;

namespace Library.Application.Interfaces;

public interface IAppealRepository
 {
    Task<Appeal?> GetAppealWithBook(Guid Id);
    Task<Appeal?> GetAppealWithPatrion(Guid Id);
    Task<Appeal?> GetWholeAppeal(Guid Id);
    Task<Appeal?> GetEntityByIdAsync(Guid id);
    Task<IEnumerable<Appeal>?> GetAllEntities();
    Task<bool> AddAsync(Appeal entity);
    bool UpdateAsync(Appeal entity);
    Task SaveAsync();
    Task<bool> DeleteEntityById(Guid id);
    bool DeleteEntity(Appeal entity);
 }
