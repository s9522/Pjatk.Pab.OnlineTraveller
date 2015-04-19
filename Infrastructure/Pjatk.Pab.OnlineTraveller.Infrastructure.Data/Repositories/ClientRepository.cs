using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }
    }
}