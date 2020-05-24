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
        public  List<Product> _myProducts = new List<Product>();
        
        public MainWindow()
        {
            InitializeComponent();
            SeedProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd objproductAdd = new ProductAdd(this);
            objproductAdd.Show();
            ProductList.ItemsSource = _myProducts;
        }

        private void SeedProducts()
        {            
            AddNewProduct("Onion", 01, 0.5, true, "01/02/2020 07:32:17");
            AddNewProduct("Salat", 02, 1, true, "01/02/2020 07:32:17");
            AddNewProduct("Pickle", 03, 2.5, true, "01/02/2020 07:32:17");
            AddNewProduct("Potato", 04, 8.56, true, "01/02/2020 07:32:17");
            AddNewProduct("Tomato", 05, 0.05, false, "01/02/2020 07:32:17");
            ProductList.ItemsSource = _myProducts;
        }

        public void AddNewProduct(string productName, int productID, double productWeight, bool productAddled, string productBuyed)
        {
            _myProducts.Add(new Product(productName, productID, productWeight, productAddled, productBuyed));
        }        
    }
}
