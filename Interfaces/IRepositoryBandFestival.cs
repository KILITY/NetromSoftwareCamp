using MyApplication.Entities;

namespace MyApplication.Interfaces;

public interface IRepositoryBandFestival : IRepositoryBase<BandFestival>
{
    Task<List<Band>> GetBandsByFestivalIdAsync(Guid festivalId);

    Task<List<Guid>> GetBandIdsInDateRangeAsync(DateTime? start, DateTime? end, Guid? excludeFestivalId = null);
}