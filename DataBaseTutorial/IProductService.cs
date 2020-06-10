using System.Collections.Generic;

namespace DataBaseTutorial
{
    public interface IProductService
    {        
        List<Product> GetProductList();
        Product ValidateAndAddNewProduct(string productName, string productWeight, bool productAddled, string productBuyed);
    }
}