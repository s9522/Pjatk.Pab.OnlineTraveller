using System.Data.Entity;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Data.EntityFramework
{
    public class TestDbInitializer : DropCreateDatabaseAlways<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            base.Seed(context);
            //TODO: dodać dane testowe
        }
    }
}