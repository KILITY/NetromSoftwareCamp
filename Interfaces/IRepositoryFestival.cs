using MyApplication.Entities;

namespace MyApplication.Interfaces;

public interface IRepositoryFestival : IRepositoryBase<Festival>
{ 
    Task<IEnumerable<Festival>> GetAllWithBandsAsync();

    Task<Festival?> GetWithBandsByIdAsync(Guid id);
}