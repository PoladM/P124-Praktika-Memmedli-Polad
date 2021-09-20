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

        public Sale(double salesamount, DateTime date)
        {
            count++;
            SalesNumber = count;
            SalesAmount = salesamount;
            Date = date;
            Salesİtem = new Salesİtem[0];
        }
        

        public void AddSalesItem(Salesİtem salesİtem)
        {
            Array.Resize(ref Salesİtem, Salesİtem.Length + 1);
            Salesİtem[Salesİtem.Length - 1] = salesİtem;
        }

        
        
    }
}
