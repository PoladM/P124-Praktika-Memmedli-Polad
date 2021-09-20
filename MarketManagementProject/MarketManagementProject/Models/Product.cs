using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    class Product
    {
        private static int count = 100;

        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductCount { get; set; }

        public Category Category;
        public int ProductCode { get; set; }

        public Product(string productname, double productprice, double productcount, Category category)
        {
            count++;
            ProductName = productname;
            ProductPrice = productprice;
            ProductCount = productcount;
            Category = category;
            ProductCode = count;
        }


    }
}
