using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac.Core;
using Microsoft.EntityFrameworkCore;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Bootstrapper.Start();
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}
