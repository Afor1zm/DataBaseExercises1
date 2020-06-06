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
