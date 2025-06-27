using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoyBand : RepositoryBase<Band>, IRepositoryBand
{
    public RepositoyBand(ShowTimeContext context) : base(context)
    {
        
    }
}