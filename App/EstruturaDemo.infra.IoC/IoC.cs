using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace EstruturaDemo.infra.IoC
{
    public class IoC
    {
        public static void Init()
        {
            var kernel = new StandardKernel(new IoCModule());

            ServiceLocator.SetLocatorProvider( ()=> new NinjectServiceLocator(kernel));
        }
    }
}
