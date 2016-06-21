using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Bike : Vehicle
    {
        public Bike(string color, int price)
            :base(color, price)
        {
            this.wheels = 2;
        }
    }
}
