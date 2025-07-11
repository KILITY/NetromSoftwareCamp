namespace MyApplication.Interfaces;

public interface IRepositoryBase<T> where T: class
{
    Task<T?> GetByIdAsync(Guid id);

    Task<IEnumerable<T>> GetAllAsync();

    Task AddASync(T entity);

    void Update(T entity);

    void Delete(T entity);

    Task SaveChangesAsync(T entity);

    Task<bool> SaveAsync();

}