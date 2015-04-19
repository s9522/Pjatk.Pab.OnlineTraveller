using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;
using Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(DbContext context) : base(context)
        {
        }
    }
}