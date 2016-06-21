using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_Vehicles
{
    class Bike : Vehicle
    {
        private static int totalBikes = 0;

        public Bike(string color, string make, string model, int price)
            :base(color, make, model, price)
        {
            this.wheels = 2;
            totalBikes += 1;
        }

        public static void bikeStock()
        {
            Console.WriteLine("There are currently {0} bikes in stock.", totalBikes.ToString());
        }

        new public void wheelNum()
        {
            Console.WriteLine("This bike has a grand total of {0} wheels", this.wheels);
        }
    }
}
