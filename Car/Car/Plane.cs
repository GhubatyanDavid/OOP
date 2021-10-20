using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Plane : Vehicle
    {
        public Plane(int Year,int NumberofPassenger,int x,int y,int height):base(Year,NumberofPassenger,x,y)
        {
            Console.WriteLine($"Plane Height is`{height}");
            Console.WriteLine($"Pleane Cordinate is` X-{x},Y-{y}");
            Console.WriteLine($"Plane Number of Passengers `{NumberofPassenger}");
            Console.WriteLine($"Plane Year is ` {Year}");
        }


}
}
