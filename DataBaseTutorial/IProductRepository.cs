using System.Collections.Generic;

namespace DataBaseTutorial
{
    public interface IProductRepository
    {
        Product AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed);
        List<Product> GetProductList();
    }
}