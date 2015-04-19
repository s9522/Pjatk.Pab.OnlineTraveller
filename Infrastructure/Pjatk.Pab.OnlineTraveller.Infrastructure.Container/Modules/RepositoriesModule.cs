using Microsoft.Practices.Unity;
using Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories;
using Pjatk.Pab.OnlineTraveller.Infrastructure.Data.Repositories;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Container.Modules
{
    public static class RepositoriesModule
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}