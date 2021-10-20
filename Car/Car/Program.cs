using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 1480;
            int price = 18000;
            int speed = 160;
            int year = 2020;
            int x = 15;
            int y = 30;
            int numberofPassenger = 5;
            int portNumber = 14;
            Vehicle vehicle = new Vehicle(year,numberofPassenger,x,y);
            Plane plane = new Plane(year,numberofPassenger,x,y,height);
            Ship ship = new Ship(numberofPassenger, year,x,y,portNumber);
            Car car = new Car(year, numberofPassenger,price,speed,x,y);

         }
    }
}
