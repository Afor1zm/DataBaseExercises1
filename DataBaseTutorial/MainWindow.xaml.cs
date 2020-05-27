using System.Collections.Generic;
using System.Windows;

namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BusinessLogic businessLogic = new BusinessLogic();
        private MainWindow _parent;
        public MainWindow()
        {
            InitializeComponent();
            businessLogic.BussinessLogic(MainWindow parent);
            businessLogic.SeedProducts();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd objproductAdd = new ProductAdd();
            objproductAdd.Show();
            ProductList.ItemsSource = businessLogic._myProducts;
        }
    }
}
