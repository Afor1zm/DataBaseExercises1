using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace DataBaseTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static List<Product> _myProducts;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd objproductAdd = new ProductAdd();
            
            objproductAdd.Show();
            ProductList.ItemsSource = _myProducts;
        }    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _myProducts = new List<Product>();
            _myProducts.Add(new Product("Onion", 01, 0.5, true,"01/02/2020 07:32:17"));
            _myProducts.Add(new Product("Salat", 02, 1, true, "01/02/2020 07:32:17"));
            _myProducts.Add(new Product("Pickle", 03, 2.5, true, "01/02/2020 07:32:17"));
            _myProducts.Add(new Product("Potato", 04, 8.56, true, "01/02/2020 07:32:17"));
            _myProducts.Add(new Product("Tomato", 05, 0.05, false, "01/02/2020 07:32:17"));
            ProductList.ItemsSource = _myProducts;
        }
    }
}
