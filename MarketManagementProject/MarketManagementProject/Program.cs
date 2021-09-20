using System;
using System.Linq;

namespace MarketManagementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketableService marketableService = new MarketableService();
            do
            {

                Console.WriteLine("1.Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2.Satislar uzerinde emeliyyat aparmaq");
                Console.WriteLine("3.Sistemden cixmaq");

                string button = Console.ReadLine();

                switch (button)
                {

                    case "1":

                        //string mainmenubutton = "0";
                        do
                        {
                            Console.WriteLine("1.1 Yeni mehsul elave etmek");
                            Console.WriteLine("1.2 Mehsul uzerinde duzelis et");
                            Console.WriteLine("1.3 Categoriyasina gore mehsullari goster");
                            Console.WriteLine("1.4 Qiymet araligina gore mehsullari goster ");
                            Console.WriteLine("1.5 Mehsullar arasinda ada gore axtaris et ");
                            Console.WriteLine("0 Ana Menuya geri don");






                            button = Console.ReadLine();
                            switch (button)
                            {
                                case "1.1":
                                    AddProduct(ref marketableService);
                                    break;
                                case "1.2":
                                    EditProduct(ref marketableService);
                                    break;
                                case "1.3":
                                    ShowProductByCategory(ref marketableService);
                                    break;
                                case "1.4":
                                    ShowProductByProductPrice(ref marketableService);
                                    break;
                                case "1.5":
                                    ShearchProductByGivenProductText(ref marketableService);
                                    break;

                                case "0":
                                    break;
                                default:
                                    Console.WriteLine("Secdiyiniz emeliyyat movcud deyil, tekrar secin!!!");
                                    break;
                            }
                        } while (!(button == "0"));
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("2.1 Yeni satis elave etmek  ");
                            Console.WriteLine("2.2 Butun satislarin ekrana cixarilmasi ");
                            Console.WriteLine("2.3 Satisdaki hansisa mehsulun geri qaytarilmasi");
                            Console.WriteLine("2.4 Verilen tarix araligina gore satislarin gosterilmesi");
                            Console.WriteLine("2.5 Verilen mebleg araligina gore satislarin gosterilmesi");
                            Console.WriteLine("2.6 Verilmis bir tarixde olan satislarin gosterilmesi");
                            Console.WriteLine("2.7 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
                            Console.WriteLine("0 Ana Menuya geri don");

                            button = Console.ReadLine();

                            switch (button)
                            {
                                case "2.1":
                                    AddSales(ref marketableService);
                                    break;
                                case "2.2":
                                    ReturnSales(ref marketableService);
                                    break;
                                case "2.3":
                                    ReturnProductFromSales(ref marketableService);
                                    break;
                                case "2.4":
                                    ShowSalesByDateRange(ref marketableService);
                                    break;
                                case "2.5":
                                    ShowSalesBySalesAmount(ref marketableService);
                                    break;
                                case "2.6":
                                    ShowSalesByDate(ref marketableService);
                                    break;
                                case "2.7":
                                    ShowSalesByGivenSalesNumber(ref marketableService);
                                    break;
                                case "0":
                                    break;
                                default:
                                    Console.WriteLine("Secdiyiniz emeliyyat movcud deyil, tekrar secin!!!");
                                    break;
                            }
                        } while (!(button == "0"));
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Secdiyiniz emeliyyat movcud deyil, tekrar secin!!!");
                        break;
                }

            } while (true);

            static void AddProduct(ref MarketableService marketableService)
            {
                Console.WriteLine("Name:");
                string productname = Console.ReadLine();
                Console.WriteLine("Price:");
                double productprice = int.Parse(Console.ReadLine());
                Console.WriteLine("Say:");
                int productcount = int.Parse(Console.ReadLine());
                string category;
                string[] typeNames = Enum.GetNames(typeof(Category));
                for (int i = 0; i < typeNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {typeNames[i]}");
                }
                int typeInt;
                do
                {
                    Console.WriteLine("Secim edin:");
                    category = Console.ReadLine();
                } while (!int.TryParse(category, out typeInt));
                Category category1 = (Category)typeInt;

                marketableService.AddProduct(productname, productprice, productcount, category1);
                
            }

            static void EditProduct(ref MarketableService marketableService)
            {
                Console.WriteLine("Edit ucun product kodu daxil edin");
                Console.WriteLine("Product kodlari 101 den baslayir.");
                int productcode = int.Parse(Console.ReadLine());
                Console.WriteLine("newName:");
                string productname = Console.ReadLine();
                Console.WriteLine("newPrice:");
                double productprice = int.Parse(Console.ReadLine());
                Console.WriteLine("newCount:");
                int productcount = int.Parse(Console.ReadLine());
                string category;
                string[] typeNames = Enum.GetNames(typeof(Category));
                for (int i = 0; i < typeNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {typeNames[i]}");
                }
                int typeInt;
                do
                {
                    Console.WriteLine("Secim edin:");
                    category = Console.ReadLine();
                } while (!int.TryParse(category, out typeInt));
                Category category1 = (Category)typeInt;

                marketableService.EditProduct(productcode, productname, productprice, productcount, category1);
            }

            static void ShowProductByCategory(ref MarketableService marketableService)
            {
                string[] typeNames = Enum.GetNames(typeof(Category));
                for (int i = 0; i < typeNames.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {typeNames[i]}");
                }
                string category;
                int typeInt;
                do
                {
                    Console.WriteLine("Secim edin:");
                    category = Console.ReadLine();
                } while (!int.TryParse(category, out typeInt));
                Category category1 = (Category)typeInt;
                if (marketableService.ShowProductByCategory(category1).Length != 0)
                {
                    foreach (var item in marketableService.ShowProductByCategory(category1))
                    {
                        Console.WriteLine($"Kod:{item.ProductCode} Say:{item.ProductCount} Mehsul Adi:{item.ProductName} Novu:{item.Category} {item.ProductPrice}AZN");
                    }
                }
                else
                {
                    Console.WriteLine("Melumat yoxdur.");
                }
            }

            static void ShowProductByProductPrice(ref MarketableService marketableService)
            {
                Console.WriteLine("Qiymet araliqini qeyd edin. Excample: (x AZN - den, y AZN - ye)");
                int minproductprice = int.Parse(Console.ReadLine());
                int maxproductprice = int.Parse(Console.ReadLine());

                if (marketableService.ShowProductByProductPrice(minproductprice, maxproductprice).Length != 0)
                {
                    foreach (var item in marketableService.ShowProductByProductPrice(minproductprice, maxproductprice))
                    {
                        Console.WriteLine($"Kod:{item.ProductCode} Say:{item.ProductCount} Mehsul Adi:{item.ProductName} Novu:{item.Category} {item.ProductPrice}AZN");
                    }
                }
                else
                {
                    Console.WriteLine("Verilmis araliqda Mehsul yoxdur.");
                }
            }
            
            static void ShearchProductByGivenProductText(ref MarketableService marketableService)
            {
                Console.WriteLine("Gormek istediyiniz mehsullari daxil edin. Excample: (XYZ, ZYX, ASD)");
                string text = Console.ReadLine();
                if (marketableService.ShearchProductByGivenProductText(text).Length != 0)
                {
                    foreach (Product item in marketableService.ShearchProductByGivenProductText(text))
                    {
                        Console.WriteLine($"Kod:{item.ProductCode} Say:{item.ProductCount} Mehsul Adi:{item.ProductName} Novu:{item.Category} {item.ProductPrice}AZN");
                    }
                }
                else
                {
                    Console.WriteLine("Verilmis adda mehsullar yoxdur.");
                }
            }

            static void AddSales(ref MarketableService marketableService)
            {
                Console.WriteLine("Secim edin:");
                foreach (var item in marketableService.Products)
                {
                    Console.WriteLine($"Kodlar:{item.ProductCode}"); 
                }
                int productcode = int.Parse(Console.ReadLine());



                marketableService.AddSales(productcode);


            }

            static void ReturnSales(ref MarketableService marketableService )
            {
                foreach (var item in marketableService.ReturnSales())
                {
                    foreach (var item2 in item.Salesİtem)
                    {
                        Console.WriteLine($"Number:{item.SalesNumber} Sales amount:{item.SalesAmount} ItemCount:{item2.ItemCount} Date:{item.Date}");
                    }
                }
            }

            static void ReturnProductFromSales(ref MarketableService marketableService)
            {
                marketableService.ReturnProductFromSales();
            }

            static void ShowSalesByGivenSalesNumber(ref MarketableService marketableService)
            {
                Console.WriteLine("Numbers:");
                foreach (Sale item in marketableService.Sales)
                {
                    Console.WriteLine(item.SalesNumber);
                }
                int salesnumber = int.Parse(Console.ReadLine());


                foreach (Salesİtem item2 in marketableService.ShowSalesByGivenSalesNumber(salesnumber).Salesİtem)
                {
                    Sale item = marketableService.ShowSalesByGivenSalesNumber(salesnumber);
                    Console.WriteLine($"SaleNumber: {item.SalesNumber} Amount: {item.SalesAmount} SalesCount: {item.Date} ---- ItemNumber: {item2.ItemNumber} Item: {item2.ItemProduct} Count: {item2.ItemCount}");
                }
            }

            static void ShowSalesByDate(ref MarketableService marketableService)
            {
                Console.WriteLine("Sales Date:");
                DateTime date = DateTime.Parse(Console.ReadLine());

                foreach (Sale item in marketableService.ShowSalesByDate(date))
                {
                    foreach (var item2 in item.Salesİtem)
                    {
                        Console.WriteLine($"Number:{item.SalesNumber} Sales amount:{item.SalesAmount} ItemCount:{item2.ItemCount} Date:{item.Date}");
                    }
                }
            }

            static void ShowSalesByDateRange(ref MarketableService marketableService)
            {
                Console.WriteLine("Sale Date1 - Sale Date2");
                Console.WriteLine("Date1");
                DateTime datefrom = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Date2");
                DateTime dateto = DateTime.Parse(Console.ReadLine());

                foreach (Sale item in marketableService.ShowSalesByDateRange(datefrom, dateto))
                {
                    foreach (var item2 in item.Salesİtem)
                    {
                        Console.WriteLine($"Number:{item.SalesNumber} Sales amount:{item.SalesAmount} ItemCount:{item2.ItemCount} Date:{item.Date}");
                    }
                }
            }

            static void ShowSalesBySalesAmount(ref MarketableService marketableService)
            {
                Console.WriteLine("Sale Amount1 - Sale Amount2");
                Console.WriteLine("Amount1:");
                int salesamountfrom = int.Parse(Console.ReadLine());

                Console.WriteLine("Amount2:");
                int salesamountto = int.Parse(Console.ReadLine());

                foreach (Sale item in marketableService.ShowSalesBySalesAmount(salesamountfrom, salesamountto))
                {
                    foreach (var item2 in item.Salesİtem)
                    {
                        Console.WriteLine($"Number:{item.SalesNumber} Sales amount:{item.SalesAmount} ItemCount:{item2.ItemCount} Date:{item.Date}");
                    }
                }
            }
        }
    }
}
