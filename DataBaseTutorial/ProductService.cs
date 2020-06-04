using DataBaseTutorial.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DataBaseTutorial
{
    public class ProductService : IProductService
    {
        public ProductService()
        {
            SeedProducts();
        }        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productWeight"></param>
        /// <param name="productAddled"></param>
        /// <param name="productBuyed"></param>
        public void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed)
        {            
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.Product.Add(new Product(productName, dbContext.Product.Count()+1, productWeight, productAddled, productBuyed));
                dbContext.SaveChanges();
            }
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productWeight"></param>
        /// <param name="productAddled"></param>
        /// <param name="productBuyed"></param>
        public void ValidateAndAddNewProduct(string productName, string productWeight, bool productAddled, string productBuyed)
        {
            ProductValidator validator = new ProductValidator();
            {
                try
                {
                    using (DatabaseContext dbContext = new DatabaseContext())
                    {
                        validator.ValidateAndThrow(new Product(productName, dbContext.Product.Count() + 1, Convert.ToDouble(productWeight), productAddled, productBuyed), ruleSet: "default");
                        {
                            AddNewProduct(productName, Convert.ToDouble(productWeight), ((bool)productAddled == true), productBuyed);
                        }
                    }                        
                }
                catch
                {
                    MessageBox.Show("Use only number for ID and Weighy. Data cn't be less than 1 year before");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProductList()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.Product.Add(new Product());
                return dbContext.Product.ToList();
            }
            
        }

        private void SeedProducts()
        {
            AddNewProduct("Onion", 0.5, true, "12/02/2020");
            AddNewProduct("Salat", 1, true, "01/02/2020");
            AddNewProduct("Pickle", 2.5, true, "01/02/2020");
            AddNewProduct("Potato", 8.56, true, "01/02/2020");
            AddNewProduct("Tomato", 0.05, false, "01/02/2020");
        }
    }
}
