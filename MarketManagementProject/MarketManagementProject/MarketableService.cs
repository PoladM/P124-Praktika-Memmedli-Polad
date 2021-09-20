﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementProject
{
    class MarketableService : IMarketable
    {
        private Sale[] _sales;
        public Sale[] Sales => _sales;

        private Product[] _products;
        public Product[] Products => _products;
        public MarketableService()
        {
            _sales = new Sale[0];
            _products = new Product[0];
        }

        public void AddProduct(string productname, double productprice, int productcount, Category category)
        {

            Product product = new Product(productname, productprice, productcount, category);
           
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;

            

            foreach (var item in _products)
            {
                Console.WriteLine($"{item.ProductName} {item.Category}");
            }
            

        }

        public void AddSales(int productcode)
        {
            foreach (Product item in _products)
            {
                if (item.ProductCount != 0)
                {
                    if (item.ProductCode == productcode)
                    {


                        string itemproduct = item.ProductName;
                        Console.WriteLine($"Satilan Mehsul sayi {item.ProductCount}");
                        Console.WriteLine("Nece Mehsul Satilacaq:");
                        int itemcount = int.Parse(Console.ReadLine());
                        if (item.ProductCount >= itemcount)
                        {
                            
                                Console.WriteLine("Satis Meblegi:");
                                double salesamount = double.Parse(Console.ReadLine());
                                Console.WriteLine("Tarix:");
                                DateTime date = DateTime.Parse(Console.ReadLine());
                                Sale sales = new Sale(salesamount, date);


                                Array.Resize(ref _sales, _sales.Length + 1);
                                _sales[_sales.Length - 1] = sales;

                                Salesİtem salesİtem = new Salesİtem(itemproduct, itemcount);
                                sales.AddSalesItem(salesİtem);

                                item.ProductCount = item.ProductCount - itemcount;
                            
                        }
                        //else if(item.ProductCount == itemcount)
                        //{
                        //    Console.WriteLine("Satis Meblegi:");
                        //    double salesamount = double.Parse(Console.ReadLine());
                        //    Console.WriteLine("Tarix:");
                        //    string date = Console.ReadLine();
                        //    Sale sales = new Sale(salesamount, date);

                        //    Array.Resize(ref _sales, _sales.Length + 1);
                        //    _sales[_sales.Length - 1] = sales;

                        //    Salesİtem salesİtem = new Salesİtem(itemproduct, itemcount);
                        //    sales.AddSalesItem(salesİtem);
                        //    int i;
                        //    int pos;

                        //    pos = Array.IndexOf(_products, item);
                        //    for (i = pos; i < _products.Length - 1; i++)
                        //    {
                        //        _products[i] = _products[i + 1];
                        //    }
                        //    Array.Resize(ref _products, _products.Length - 1);
                        //}
                        else
                        {
                            Console.WriteLine($"Mehsuldan sadece {item.ProductCount} eded var.");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Mehsul bitmisdir.");
                }
            }

            
        }

        public void EditProduct(int productcode, string productname, double productprice, int productcount, Category category)
        {
            foreach (var item in _products)
            {
                if (item.ProductCode == productcode)
                {
                    item.ProductCount = productcount;
                    item.ProductName = productname;
                    item.ProductPrice = productprice;
                    item.Category = category;
                    Console.WriteLine($"Yenilendi: {item.ProductCount} {item.ProductName} {item.ProductPrice} {item.Category}");
                }
            }

        }

        public void ReturnProductFromSales(/*Sale sales, *//*string itemproduct, int itemcount*/ )
        {
            Console.WriteLine("Sales Amount:");
            double salesamount = double.Parse(Console.ReadLine());

            Console.WriteLine("Date:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ItemProduct:");
            string itemproduct = Console.ReadLine();

            Console.WriteLine("ItemCount:");
            int itemcount = int.Parse(Console.ReadLine());

            
            foreach (Sale item in _sales)
            {
                foreach (var item2 in item.Salesİtem)
                {
                    if (item.SalesAmount == salesamount && item.Date == date && item2.ItemProduct == itemproduct && item2.ItemCount == itemcount)
                    {
                        int i;
                        int pos;

                        pos = Array.IndexOf(_sales, item);
                        for (i = pos; i < _sales.Length - 1; i++)
                        {
                            _sales[i] = _sales[i + 1];
                        }
                        Array.Resize(ref _sales, _sales.Length - 1);

                        foreach (var item3 in _products)
                        {
                            item3.ProductCount = item3.ProductCount + itemcount;
                        }
                    }
                }
            }

            
        }

        public Sale[] ReturnSales()
        {
            return _sales;
        }

        public Product[] ShearchProductByGivenProductText(string text)
        {
            string[] arr = text.Split(", ");
            Product[] arr2 = new Product[0];
            foreach (string item in arr)
            {
                foreach (Product item2 in _products)
                {
                    if (item == item2.ProductName)
                    {
                        Array.Resize(ref arr2, arr2.Length + 1);
                        arr2[arr2.Length - 1] = item2;
                    }
                }
            }
                return arr2;
        }

        public Product[] ShowProductByCategory(Category category)
        {

            Product[] arr = new Product[0];
            foreach (Product item in _products)
            {
                if (item.Category == category)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = item;
                }
            }
                
                return arr;
        }

        public Product[] ShowProductByProductPrice(int minproductprice, int maxproductprice)
        {
            Product[] arr = new Product[0];
            for (int i = minproductprice; i <= maxproductprice; i++)
            {
                foreach (Product item in _products)
                {
                    if (item.ProductPrice == i)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = item;
                    }
                }
            }
            return arr;
        }

        public Sale[] ShowSalesByDate(DateTime date)
        {
            Sale[] arr = new Sale[0];
            foreach (Sale item in _sales)
            {
                if (item.Date == date)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = item;
                }
            }
            return arr;
        }

        public Sale[] ShowSalesByDateRange(DateTime datefrom, DateTime dateto)
        {
            Sale[] arr = new Sale[0];
            for (DateTime i = datefrom; i <= dateto; i=i.AddDays(1.0))
            {
                foreach (Sale item in _sales)
                {
                    if (i == item.Date)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = item;
                    }
                }
            }
            return arr;
        }

        public Sale ShowSalesByGivenSalesNumber(int salesnumber)
        {
            foreach (var item in _sales)
            {
                //foreach (var item2 in item.Salesİtem)
                //{
                    if (item.SalesNumber == salesnumber)
                    {
                        //Console.WriteLine($"SaleNumber: {item.SalesNumber} Amount: {item.SalesAmount} SalesCount: {item.Date} ---- ItemNumber: {item2.ItemNumber} Item: {item2.ItemProduct} Count: {item2.ItemCount}");
                        return item;
                    }
                //}
            }
            return null;
        }
        
        public Sale[] ShowSalesBySalesAmount(int salesamountfrom, int salesamountto)
        {
            Sale[] arr = new Sale[0];
            for (int i = salesamountfrom; i <= salesamountto; i++)
            {
                foreach (var item in _sales)
                {
                    if (item.SalesAmount == i)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = item;
                    }
                }
            }
            return arr;
        }

    }
}
