using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories
{
    public class TravelRepository : GenericRepository<Travel>, ITravelRepository
    {
        public TravelRepository(DbContext context) : base(context)
        {
        }
    }
}