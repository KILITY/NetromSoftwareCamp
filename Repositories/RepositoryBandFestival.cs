using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryBandFestival : RepositoryBase<BandFestival>, IRepositoryBandFestival
{
    public RepositoryBandFestival(ShowTimeContext context) : base(context)
    {
        
    }
}