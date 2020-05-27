using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DataBaseTutorial
{
    public class BusinessLogic : Window
    {
        public List<Product> _myProducts = new List<Product>();
        private  MainWindow _parent;
        
        public void BussinessLogic(MainWindow parent)
        {
            _parent = parent;
        }

        public void SeedProducts()
        {
            
            AddNewProduct("Onion", 0.5, true, "12/02/2020");
            AddNewProduct("Salat", 1, true, "01/02/2020");
            AddNewProduct("Pickle", 2.5, true, "01/02/2020");
            AddNewProduct("Potato", 8.56, true, "01/02/2020");
            AddNewProduct("Tomato", 0.05, false, "01/02/2020");
            _parent.ProductList.ItemsSource = _myProducts;
        }

        public void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed)
        {
            _myProducts.Add(new Product(productName, _myProducts.Count + 1, productWeight, productAddled, productBuyed));
        }

        public void Refresh()
        {
            _parent.ProductList.Items.Refresh();
        }
    }
}
