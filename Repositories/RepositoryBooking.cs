using MyApplication.Context;
using MyApplication.Entities;
using MyApplication.Interfaces;

namespace MyApplication.Repositories;

public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
{
    public RepositoryBooking(ShowTimeContext context) : base(context)
    {
        
    }
}