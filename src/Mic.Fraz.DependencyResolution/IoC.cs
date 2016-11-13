using Autofac;
using Mic.Fraz.Business;
using Mic.Fraz.BusinessInterfaces;
using Mic.Fraz.Repository;
using Mic.Fraz.RepositoryInterfaces;

namespace Mic.Fraz.DependencyResolution
{
    public static class IoC
    {
        public static ContainerBuilder GetContainer()
        {
            var container = new ContainerBuilder();
            container.RegisterType<UserManager>().As<IUserManager>();
            container.RegisterType<UserRepository>().As<IUserRepository>();
            return container;
        }
    }
}
