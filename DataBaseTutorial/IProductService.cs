using System.Collections.Generic;

namespace DataBaseTutorial
{
    public interface IProductService
    {
        void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed);
        List<Product> GetProductList();
        void ValidateAndAddNewProduct(string productName, string productWeight, bool productAddled, string productBuyed);
    }
}