using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    class Salesİtem
    {
        private static int count = 10;
        public int ItemNumber { get; set; }
        public string ItemProduct { get; set; }
        public int ItemCount { get; set; }

        public Salesİtem(string itemproduct, int itemcount)
        {
            count++;
            ItemNumber = count;
            ItemCount = itemcount;
            ItemProduct = itemproduct;
        }

        
    }
}
