using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryBand : RepositoryBase<Band>, IRepositoryBand
{
    public RepositoryBand(ShowTimeContext context) : base(context)
    {
        
    }
}