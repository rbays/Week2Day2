using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Vehicle
    {
        public string color;
        public int wheels;
        public static int totalVehicles = 0;
        public int price;
        public bool sold;
        public static int income = 0;

        public Vehicle(string color, int price)
        {
            this.color = color;
            this.wheels = 4;
            this.price = price;
            this.sold = false;
            totalVehicles++;
        }
        public void SellVehicle()
        {
            this.sold = true;
            totalVehicles -= 1;
            income += this.price;
        }

        public static void NumOfVehicles()
        {
            Console.WriteLine("We have a total of {0} cars.", totalVehicles);
        }

        public void NumOfWheels()
        {
            Console.WriteLine("This Vehicle has {0} wheels", this.wheels);
        }
    }
}