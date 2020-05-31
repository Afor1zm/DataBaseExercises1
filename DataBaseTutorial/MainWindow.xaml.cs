using Autofac.Core;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            var container = Bootstrapper.Resolve<IProductService>();
            InitializeComponent();
            Bootstrapper.Start();            
            container.BussinessLogic();            
            container.GetProductList();
            ProductList.ItemsSource = container.GetProductList();
            ProductList.Items.Refresh();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var container = Bootstrapper.Resolve<IProductService>();
            ProductAdd objproductAdd = new ProductAdd();
            objproductAdd.Show();
            var newProducts = container.GetProductList().Except(container.GetProductList());
            container.GetProductList().AddRange(newProducts);
            ProductList.Items.Refresh();
        }
    }
}
