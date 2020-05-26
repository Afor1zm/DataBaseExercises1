using System;

namespace DataBaseTutorial
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public double ProductWeight {get;set;}
        public bool ProductAddled { get; set; }
        public DateTime ProductBuyedDate { get; set; } 
        public Product(string productName, int productID, double productWeight, bool productAddled, string productBuyed)
        {
            ProductName = productName;
            ProductId = productID;
            ProductWeight = productWeight;
            ProductAddled = productAddled;
            ProductBuyedDate = Convert.ToDateTime(productBuyed);
        }        
    }
}
