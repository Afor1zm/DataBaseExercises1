using DataBaseTutorial.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using FluentValidation;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

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

        /// <summary>
        /// Seed default products for product list
        /// </summary>
        private void SeedProducts()
        {            
            AddNewProduct("Onion", 01, 0.5, true, "12/02/2020");
            AddNewProduct("Salat", 02, 1, true, "01/02/2020");
            AddNewProduct("Pickle", 03, 2.5, true, "01/02/2020");
            AddNewProduct("Potato", 04, 8.56, true, "01/02/2020");
            AddNewProduct("Tomato", 05, 0.05, false, "01/02/2020");
            ProductList.ItemsSource = _myProducts;
        }

        /// <summary>
        /// Add New Product to product list
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productID"></param>
        /// <param name="productWeight"></param>
        /// <param name="productAddled"></param>
        /// <param name="productBuyed"></param>
        public void AddNewProduct(string productName, int productID, double productWeight, bool productAddled, string productBuyed)
        {
            _myProducts.Add(new Product(productName, productID, productWeight, productAddled, productBuyed));
        }
    }
}
