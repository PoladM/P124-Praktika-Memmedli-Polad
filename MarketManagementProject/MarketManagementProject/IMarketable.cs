using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    interface IMarketable
    {
        public Sale[] Sales { get; }
        public Product[] Products { get; }
        public void AddSales(int productcode);
        public void ReturnProductFromSales();
        public Sale[] ReturnSales();
        public Sale[] ShowSalesByDateRange(DateTime datefrom, DateTime dateto);
        public Sale[] ShowSalesByDate(DateTime date);
        public Sale[] ShowSalesBySalesAmount(int salesamountfrom, int salesamountto);
        public Sale ShowSalesByGivenSalesNumber(int salesnumber);
        public void AddProduct(string productname, double productprice, int productcount, Category category);
        public void EditProduct(int productcode, string productname, double productprice, int productcount, Category category);
        public Product[] ShowProductByCategory(Category category);
        public Product[] ShowProductByProductPrice(int minproductprice, int maxproductprice);
        public Product[] ShearchProductByGivenProductText(string text);
        
    }
}
