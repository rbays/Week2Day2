using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_Vehicles
{
    class Car : Vehicle
    {
        private static int totalCars = 0;

        public Car(string color, string make, string model, int price)
            :base(color, make, model, price)
        {
            this.wheels = 4;
            totalCars += 1;
        }

        public static void carStock()
        {
            Console.WriteLine("There are currently {0} cars in stock.", totalCars.ToString());
        }

        new public void wheelNum()
        {
            Console.WriteLine("This car has a total of {0} wheels", this.wheels);
        }
        public override void checkColor()
        { 
            Console.WriteLine("The car is " + this.color);
        }
    }
}
