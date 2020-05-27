using System;

namespace DataBaseTutorial
{
    interface IProduct
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public double ProductWeight { get; set; }
        public bool ProductAddled { get; set; }
        public DateTime ProductBuyedDate { get; set; }
    }
}
