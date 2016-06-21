using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", 10000);
            Car car2 = new Car("yellow", 5000);
            Car car3 = new Car("pink", 7000);

            Console.WriteLine("The first car costs {0}", car1.price.ToString());
            Car.NumOfVehicles();

            car1.SellVehicle();
            car2.SellVehicle();

            Car.NumOfVehicles();
            Console.WriteLine("Total income is {0}", Vehicle.income);

            Bike bike1 = new Bike("black", 4000);

            bike1.NumOfWheels();
            car1.NumOfWheels();

        }
    }
}
