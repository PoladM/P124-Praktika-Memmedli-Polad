using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Product 
    {
        public string Name;
        public int Price;
        public int Count;
        public int TotalInCome;

        public Product(string name) 
        {
            Name = name;
        }

        public void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalInCome = TotalInCome + Price;
                Console.WriteLine($"mehsul sayi:{Count}\ngelir:{TotalInCome}");
            }
            else
            {
                Console.WriteLine("Hecbir mehsul yoxdur.");
            }
        }

    }
}
