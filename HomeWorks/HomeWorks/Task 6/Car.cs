using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public int FuelFor1Km;
        public int CurrentFuel;
        public Car(string model,string brand, int fuelfor1km,int fuelcapacity,string year) : base(year)
        {
            
            Model = model;
            Brand = brand;
            FuelCapacity = fuelcapacity;
            FuelFor1Km = fuelfor1km;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand},Model:{Model},Yanacq limiti:{FuelCapacity}\n 1 km serf edilecek yanacaq:{FuelFor1Km},Cari yanacaq:{CurrentFuel}, Ili:{Year}, Rengi:{Color}");
        }

        public void AddFuel(int AmountOfFuel)
        {
            if (AmountOfFuel < FuelCapacity)
            {
                Console.WriteLine($"{AmountOfFuel}L yanacaq elave edildi.");
                CurrentFuel = CurrentFuel + AmountOfFuel;
                Console.WriteLine($"Yanacaq miqdari {CurrentFuel}");
            }
            else
                Console.WriteLine($"{AmountOfFuel} yanacaq miqdarini asmisdir.");           
        }
        public void Drive(int km)
        {
            if (CurrentFuel != 0)
                Console.WriteLine($"{Model} ise salindi. Yanacaq:{CurrentFuel}L, 1 km ucun yanaq:{FuelFor1Km}L, Gedilecek yol:{km}km");
            else
                Console.WriteLine("Yanacaq yoxdur");
        }

    }
}
