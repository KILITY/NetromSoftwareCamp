using Microsoft.EntityFrameworkCore;
using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryBandFestival : RepositoryBase<BandFestival>, IRepositoryBandFestival
{
    public RepositoryBandFestival(ShowTimeContext context) : base(context)
    {
        
    }

    public Task<List<Band>> GetBandsByFestivalIdAsync(Guid festivalId)
    {
        return Context.BandFestivals
            .Where(bf => bf.FestivalId == festivalId)
            .OrderBy(bf => bf.Order)
            .Select(bf => bf.Band)
            .ToListAsync();
    }
}