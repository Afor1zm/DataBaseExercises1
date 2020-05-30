using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductService>().As<IProductService>();
            
            // Add the MainWindowclass and later resolve
            builder.RegisterType<MainWindow>().AsSelf();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var window = scope.Resolve<MainWindow>();
                window.Show();
            }
        }
    }
}
