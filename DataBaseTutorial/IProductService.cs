using System.Collections.Generic;

namespace DataBaseTutorial
{
    public interface IProductService
    {
        void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed);
        void BussinessLogic();
        List<Product> GetProductList();
        void SeedProducts();
        void ValidateNewProduct(string productName, string productWeight, bool productAddled, string productBuyed);
    }
}