
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car
{
    class Ship : Vehicle
    {
        public Ship(int numberofPassenger,int year,int x,int y,int portNumber):base(numberofPassenger,year,x,y)
        {
            Console.WriteLine($"Ship Passenger number is ` {numberofPassenger}");
            Console.WriteLine($"Ship Port Cordinate is` X-{x},Y-{y}");
            Console.WriteLine($"Ship Year is` {year}");
            Console.WriteLine($"Ship Port Number is `{portNumber}");
        }
       
    }
}
