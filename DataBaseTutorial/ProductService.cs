using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using FluentValidation;
using DataBaseTutorial.Validators;

namespace DataBaseTutorial
{
    public class ProductService: IProductService
    {
        private List<Product> _myProducts = new List<Product>();        

        public void BussinessLogic()
        {
            SeedProducts();
        }

        public void SeedProducts()
        {
            AddNewProduct("Onion", 0.5, true, "12/02/2020");
            AddNewProduct("Salat", 1, true, "01/02/2020");
            AddNewProduct("Pickle", 2.5, true, "01/02/2020");
            AddNewProduct("Potato", 8.56, true, "01/02/2020");
            AddNewProduct("Tomato", 0.05, false, "01/02/2020");
        }

        public void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed)
        {
            _myProducts.Add(new Product(productName, _myProducts.Count + 1, productWeight, productAddled, productBuyed));
        }        

        public void ValidateNewProduct(string productName, string productWeight, bool productAddled, string productBuyed)
        {
            ProductValidator validator = new ProductValidator();
            {
                try
                {
                    validator.ValidateAndThrow(new Product(productName, _myProducts.Count+1, Convert.ToDouble(productWeight), productAddled, productBuyed), ruleSet: "default");
                    {
                        AddNewProduct(productName, Convert.ToDouble(productWeight), ((bool)productAddled == true), productBuyed);                        
                    }
                }
                catch
                {
                    MessageBox.Show("Use only number for ID and Weighy. Data cn't be less than 1 year before");
                }
            }
        }

        public List<Product> GetProductList()
        {
            return _myProducts;
        }
    }
}
