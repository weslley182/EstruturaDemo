using EstruturaDemo.Domain.Interfaces;
using EstruturaDemo.Infra.Repository;
using EstruturaDemo.Infra.Repository.EF;
using Ninject.Modules;

namespace EstruturaDemo.infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
