using Autofac;
using Autofac.Core;
using System;
using System.Linq;
using System.Reflection;

namespace DataBaseTutorial
{
    public static class Bootstrapper
    {
        private static ILifetimeScope _rootScope;
        
        public static void Start()
        {
            if (_rootScope != null) return;

            var builder = new ContainerBuilder();

            builder.RegisterType<ProductService>().As<IProductService>().SingleInstance();

            _rootScope = builder.Build();            
        }

        public static T Resolve<T>()
        {
            if (_rootScope == null) throw new Exception("Bootstrapper hasn't been started!");

            return _rootScope.Resolve<T>();
        }
    }
}
