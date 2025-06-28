using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryFestival : RepositoryBase<Festival>, IRepositoryFestival
{
    public RepositoryFestival(ShowTimeContext context) : base(context)
    {
        
    }
}