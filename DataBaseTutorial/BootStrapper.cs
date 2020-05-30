using Autofac;
using Autofac.Core;
using Caliburn.Micro;
using DataBaseTutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;

namespace DataBaseTutorial
{
    public class BootStrapper : BootstrapperBase
    {
       public BootStrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }


}
