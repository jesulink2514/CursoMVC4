using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace DI.Infraestructure
{
    public class NinjectDependencyResolver: IDependencyResolver
    {
        private IKernel kernel = new StandardKernel();
        public NinjectDependencyResolver()
        {
            ApplyBindings(kernel);
        }

        private void ApplyBindings(IKernel kernel)
        {
           kernel.Bind<IMessageProvider, MessageProvider>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}