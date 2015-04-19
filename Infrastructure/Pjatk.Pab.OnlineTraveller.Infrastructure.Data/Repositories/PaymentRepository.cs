using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(DbContext context) : base(context)
        {
        }
    }
}