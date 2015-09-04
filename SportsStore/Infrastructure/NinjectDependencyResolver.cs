using System;
using System.Collections.Generic;
using Ninject;
using System.Web.Mvc;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using System.Linq;
using Moq;
using System.Configuration;
using SportsStore.Infrastructure;


namespace SportsStore.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver (IKernel kernelParam){
            kernel = kernelParam;
            AddBindings();

        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
           kernel.Bind<IProductRepository>().To<EFProductRepository>();
            
        }
    }
    }
