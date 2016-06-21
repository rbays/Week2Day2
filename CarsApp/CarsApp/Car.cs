using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Car : Vehicle
    {
        public int doors;

        public Car(string color, int price)
            :base(color, price)
        {
            this.doors = 4;
        }





    }
}
