using System;

namespace DataBaseTutorial
{
    public interface IProductService
    {
        void BussinessLogic();
        void SeedProducts();
        void AddNewProduct(string productName, double productWeight, bool productAddled, string productBuyed);
        void ValidateNewProduct(string productName, string productWeight, bool productAddled, string productBuyed);
    }
}
