using Autofac;
using Autofac.Core;
using DataBaseTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DataBaseTutorial
{
    public static class Bootstrapper
    {
        private static ILifetimeScope _rootScope;
        
        public static void Start()
        {
            if (_rootScope != null) return;

            var builder = new ContainerBuilder();
            var assemblies = new[] { Assembly.GetExecutingAssembly() };

            builder.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            builder.RegisterType<Product>().As<IProduct>().SingleInstance();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(IProductService).IsAssignableFrom(t))
                .SingleInstance()
                .AsImplementedInterfaces();
            _rootScope = builder.Build();            
        }

        public static T Resolve<T>()
        {
            if (_rootScope == null) throw new Exception("Bootstrapper hasn't been started!");

            return _rootScope.Resolve<T>(new Parameter[0]);
        }
    }
    //public class Bootstrapper : BootstrapperBase
    //{
    //    private SimpleContainer _container = new SimpleContainer();
    //    public Bootstrapper()
    //    {
    //        Initialize();
    //    }

    //    protected override void Configure()
    //    {
    //        _container.Instance(_container);
    //        _container
    //            .Singleton<IWindowManager, WindowManager>()
    //            .Singleton<IEventAggregator, EventAggregator>();


    //        _container.PerRequest<IProductService1, ProductService>();
    //        _container.

    //        GetType().Assembly.GetTypes()
    //            .Where(type => type.IsClass)
    //            .Where(type => type.Name.EndsWith("ViewModel"))
    //            .ToList()
    //            .ForEach(viewModelType => _container.RegisterPerRequest(
    //                viewModelType, viewModelType.ToString(), viewModelType));
    //    }

    //    protected override void OnStartup(object sender, StartupEventArgs e)
    //    {
    //        DisplayRootViewFor<ShellViewModel>();
    //    }

    //    protected override object GetInstance(Type service, string key)
    //    {
    //        return _container.GetInstance(service, key);
    //    }

    //    protected override IEnumerable<object> GetAllInstances(Type service)
    //    {
    //        return _container.GetAllInstances(service);
    //    }

    //    protected override void BuildUp(object instance)
    //    {
    //        _container.BuildUp(instance);
    //    }
    //    public static T Resolve<T>()
    //    {
    //        return _container.r
    //    }
    //}
}
