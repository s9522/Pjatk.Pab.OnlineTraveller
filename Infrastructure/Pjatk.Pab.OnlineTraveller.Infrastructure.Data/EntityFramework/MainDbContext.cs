using System.Data.Entity;
using Pjatk.Pab.OnlineTraveller.Core.Domain.Entities;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.EntityFramework
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("MainDbContext")
        {
        }

        public DbSet<Travel> Travels { get; set; }
        public DbSet<TravelOffer> TravelOffers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}