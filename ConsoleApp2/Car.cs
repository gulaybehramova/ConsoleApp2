using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Car : Vehicle
    {
        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length < 10)
                {
                    _brand = value;
                }
            }
        }

        public Car(string brand, string model, int Milliage, int GlobalMilliage, int FuelCapacity, int FuelFor1Km, int CurrentFuel)
        {
            Brand = brand;
            Model = model;
            Milliage = Milliage;
            GlobalMilliage = GlobalMilliage;
            FuelCapacity = FuelCapacity;
            FuelFor1Km = FuelFor1Km;
            CurrentFuel = CurrentFuel;
        }

        private string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length < 10)
                {
                    _model = value;
                }
            }
        }

        public int Milliage { get; private set; }
        public int GlobalMilliage { get; private set; }
        public int FuelCapacity { get; }
        public int FuelFor1Km { get; }
        public int CurrentFuel { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Milliage:{Milliage}");
            Console.WriteLine($"Global milliage:{GlobalMilliage}");
            Console.WriteLine($"Fuel capasity:{FuelCapacity}");
            Console.WriteLine($"Fuel for 1 km:{FuelFor1Km}");
            Console.WriteLine($"Current fuel:{CurrentFuel}");
        }



        public bool AddFuel(int fuel)
        {
            bool isOk = false;
            if(fuel + CurrentFuel <= FuelCapacity)
            {
                CurrentFuel += fuel;
                isOk=true;
                return isOk;
            }
            return isOk;    
        }



        public bool Drive(int km)
        {
            int neededFuel = km * FuelFor1Km;
            if (neededFuel <= CurrentFuel)
            {
                Milliage += km;
                GlobalMilliage += km;
                CurrentFuel -= neededFuel;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ResetMilliage()
        {
            Milliage = 0;
        }


    }
    
}
