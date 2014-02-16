using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;
using DI.Controllers;
using Ninject;

namespace DI.Infraestructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private readonly IKernel _kernel = new StandardKernel();
        public NinjectControllerFactory()
        {
            ApplyBindings(_kernel);
        }

        private void ApplyBindings(IKernel _kernel)
        {
            _kernel.Bind<IMessageProvider,MessageProvider>();
            _kernel.Bind<HomeController>();
        }
        protected override IController GetControllerInstance
            (RequestContext requestContext, Type controllerType)
        {
            return controllerType != null ? 
                _kernel.Get(controllerType) as IController : null;
        }
    }
}