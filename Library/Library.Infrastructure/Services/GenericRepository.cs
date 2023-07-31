using Library.Application.Interfaces;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Services;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private LibraryDbContext _context;
    private DbSet<TEntity> _entity;

    public GenericRepository(LibraryDbContext context)
    {
        _context = context;
        _entity = context.Set<TEntity>();
    }

    public async Task<TEntity?> GetEntityByIdAsync(Guid id)
        => await _entity.FindAsync(id);

    public async Task<IEnumerable<TEntity>?> GetAllEntities()
        => await _entity.ToListAsync();

    public async Task<bool> AddAsync(TEntity entity)
    {
        try
        {
            await _entity.AddAsync(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool UpdateAsync(TEntity entity)
    {
        try
        {
            _entity.Update(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> SaveAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteEntityById(Guid id)
    {
        try
        {
            TEntity? entity = await GetEntityByIdAsync(id);
            _entity.Remove(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool DeleteEntity(TEntity entity)
    {
        try
        {
            _entity.Remove(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }
}