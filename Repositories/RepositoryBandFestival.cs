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
    
    public async Task<List<Guid>> GetBandIdsInDateRangeAsync(DateTime? start, DateTime? end, Guid? excludeFestivalId = null)
    {
        var query = Context.BandFestivals
            .Include(bf => bf.Festival)
            .Where(bf =>
                EF.Functions.DateDiffDay(bf.Festival.StartDate, end.Value) <= 0 &&
                EF.Functions.DateDiffDay(bf.Festival.EndDate, start.Value) >= 0);

        if (excludeFestivalId.HasValue)
            query = query.Where(bf => bf.FestivalId != excludeFestivalId.Value);

        return await query.Select(bf => bf.BandId).Distinct().ToListAsync();
    }
}