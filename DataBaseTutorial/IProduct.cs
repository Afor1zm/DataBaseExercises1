using System;

namespace DataBaseTutorial
{
    public interface IProduct
    {
        bool ProductAddled { get; set; }
        DateTime ProductBuyedDate { get; set; }
        int ProductId { get; set; }
        string ProductName { get; set; }
        double ProductWeight { get; set; }
    }
}