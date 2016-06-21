using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_Vehicles
{
    class Vehicle
    {
        public int wheels;
        public string color;
        public string make;
        public string model;
        public int price;
        private static int totalVehicles = 0;

        public Vehicle(string color, string make, string model, int price )
        {
            this.color = color;
            this.make = make;
            this.model = model;
            this.price = price;
            totalVehicles += 1;
        }

        public static void vehicleStock()
        {
            Console.WriteLine("There are currently {0} vehicles in stock.", totalVehicles.ToString());
        }
        
        public void wheelNum()
        {
            Console.WriteLine("This vehicle has {0} wheels", this.wheels);
        }
        public virtual void checkColor()
        {
            Console.WriteLine("The color is " + this.color);
        }
    }
}
