using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    class Salesİtem
    {
        private static int count = 10;
        public int ItemNumber { get; set; }
        public Product ItemProduct { get; set; }
        public double ItemCount { get; set; }

        public Salesİtem(Product itemproduct, int itemcount)
        {
            count++;
            ItemNumber = count;
            ItemCount = itemcount;
            ItemProduct = itemproduct;
        }

        
    }
}
