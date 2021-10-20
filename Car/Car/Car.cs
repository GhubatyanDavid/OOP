using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car : Vehicle
    {
        public Car(int year,int numberofPassenger,int price,int speed,int x,int y):base(year,numberofPassenger,x,y)
        {
            Console.WriteLine($"The Car Year is `{year}");
            Console.WriteLine($"The Car Passengers is` {numberofPassenger}");
            Console.WriteLine($"The Car Price is`{price}$");
            Console.WriteLine($"The Car Max Speed is`{speed}");
        }
    }
}
