using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    class Sale
    {
        private static int count = 1000;
        public int SalesNumber { get; set; }
        public double SalesAmount { get; set; }
        public Salesİtem[] Salesİtem;
        public DateTime Date { get; set; }

        public Sale(DateTime date)
        {
            Salesİtem = new Salesİtem[0];
            count++;
            SalesNumber = count;
            Date = date;
        }


        public void AddSalesItem(Salesİtem salesİtem)
        {
            Array.Resize(ref Salesİtem, Salesİtem.Length + 1);
            Salesİtem[Salesİtem.Length - 1] = salesİtem;
        }
        public void DeclareSalesAmount()
        {
            foreach (var item in Salesİtem)
            {
                SalesAmount = item.ItemCount * item.ItemProduct.ProductPrice;
            }
        }



    }
}
