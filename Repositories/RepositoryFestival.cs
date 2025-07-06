using Microsoft.EntityFrameworkCore;
using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryFestival : RepositoryBase<Festival>, IRepositoryFestival
{
    public RepositoryFestival(ShowTimeContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Festival>> GetAllWithBandsAsync()
    {
        return await Context.Festivals.Include(x => x.BandFestivals)
            .ThenInclude(x => x.Band).ToListAsync();
    }

    public async Task<Festival?> GetWithBandsByIdAsync(Guid id)
    {
        return await Context.Festivals
            .Include(x => x.BandFestivals)
            .ThenInclude(x => x.Band)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}