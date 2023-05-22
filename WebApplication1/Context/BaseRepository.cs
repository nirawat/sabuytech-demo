
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Context;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected DbContext _appDbContext;

    public BaseRepository(DbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<T?> GetByIdAsync<TId>(TId id)
    {
        return await _appDbContext.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> ListAllAsync()
    {
        return await _appDbContext.Set<T>().ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        _appDbContext.Set<T>().Add(entity);
        await _appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<int> DeleteAsync(T entity)
    {
        _appDbContext.Set<T>().Remove(entity);
        return await _appDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _appDbContext.Entry(entity).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
    }
}