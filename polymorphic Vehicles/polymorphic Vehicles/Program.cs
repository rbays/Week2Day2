using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("red", "Honda", "Prius", 15000);
            Car car2 = new Car("green", "Ford", "Fiesta", 12000);
            Bike bike1 = new Bike("silver", "Yamaha", "Blade", 7000);

            car1.wheelNum();
            bike1.wheelNum();
            (bike1 as Vehicle).wheelNum();
            car1.checkColor();


            Vehicle.vehicleStock();
            Car.carStock();
            Bike.bikeStock();
            
        }
      
    }
}
