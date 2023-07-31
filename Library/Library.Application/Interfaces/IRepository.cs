namespace Library.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
   public Task<TEntity> GetEntityById(Guid id);
   public Task<IEnumerable<TEntity>> GetAllEntities();
   public Task<bool> AddAsync();
   public Task<bool> UpdateAsync();
   public Task<bool> SaveChangesAsync();
   public Task DeleteEntityAsync();
}