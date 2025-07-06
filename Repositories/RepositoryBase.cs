using Microsoft.EntityFrameworkCore;
using MyApplication.Context;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected readonly ShowTimeContext Context;
    private readonly DbSet<T> _dbSet;

    public RepositoryBase(ShowTimeContext context)
    {
        Context = context;
        _dbSet = Context.Set<T>();
    }


    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddASync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task SaveChangesAsync(T entity)
    {
        await Context.SaveChangesAsync();
    }

    public async Task<bool> SaveAsync()
    {
        await Context.SaveChangesAsync();
        return await Context.SaveChangesAsync() > 0;
    }
}