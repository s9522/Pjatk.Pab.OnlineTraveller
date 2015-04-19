using System.Data.Entity;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.EntityFramework
{
    public class MainDbInitializer : DropCreateDatabaseIfModelChanges<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            base.Seed(context);
            //TODO: dodać dane testowe
        }
    }
}