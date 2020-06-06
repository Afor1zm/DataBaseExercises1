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
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="productWeight"></param>
        /// <param name="productAddled"></param>
        /// <param name="productBuyed"></param>
        public Product ValidateAndAddNewProduct(string productName, string productWeight, bool productAddled, string productBuyed)
        {
            ProductValidator validator = new ProductValidator();
            {
                try
                {
                    validator.ValidateAndThrow(new Product(productName, Convert.ToDouble(productWeight), productAddled, productBuyed), ruleSet: "default");
                    {
                        return _productRepository.AddNewProduct(productName, Convert.ToDouble(productWeight), ((bool)productAddled == true), productBuyed);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Use only number for ID and Weighy. Data cn't be less than 1 year before. {ex.Message}");
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProductList()
        {
            return _productRepository.GetProductList();
        }
    }
}
