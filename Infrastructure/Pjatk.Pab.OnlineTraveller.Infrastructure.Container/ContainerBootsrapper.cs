using Microsoft.Practices.Unity;
using Pjatk.Pab.OnlineTraveller.Infrastructure.Container.Modules;

namespace Pjatk.Pab.OnlineTraveller.Infrastructure.Container
{
    public static class ContainerBootsrapper
    {
        public static void RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();
            RepositoriesModule.RegisterTypes(container);
        }
    }
}