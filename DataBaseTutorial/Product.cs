﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataBaseTutorial
{
    public class Product : IProduct
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductWeight { get; set; }
        public bool ProductAddled { get; set; }
        public DateTime ProductBuyedDate { get; set; }
        public Product(string productName, double productWeight, bool productAddled, string productBuyed)
        {
            ProductName = productName;            
            ProductWeight = productWeight;
            ProductAddled = productAddled;
            ProductBuyedDate = Convert.ToDateTime(productBuyed);
        }
        public Product()
        {

        }
    }
}
