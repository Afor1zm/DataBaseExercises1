using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseTutorial
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
            
        }

        public List<Product> GetProductList()
        {
            return _context.Product.ToList();            
        }

        public Product AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed)
        {
            var product = new Product(productName, productWeight, productAddled, productBuyed);
            _context.Product.Add(product);
            _context.SaveChanges();
            return product;
        }
    }
}
