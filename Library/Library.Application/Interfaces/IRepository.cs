namespace Library.Application.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
   public Task<TEntity?> GetEntityByIdAsync(Guid id);
   public Task<IEnumerable<TEntity>?> GetAllEntities();
   public Task<bool> AddAsync(TEntity entity);
   public Task<bool> SaveAsync();
   public bool UpdateAsync(TEntity entity);
   public Task<bool> DeleteEntityById(Guid id);
   public bool DeleteEntity(TEntity entity);
}