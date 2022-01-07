using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class CarCollection<T>  : IVehicleCollection<T> where T : Car
     {
        public Car[] cars;

        public int Count
        {
            get { return cars.Length; }
        }
        public CarCollection(int length)
        {
            cars = new Car[length];

        }
        public Car[] Cars
        {
            get { return cars; }
        }
        public void AddVehicle(T car,int number)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); 
            }
            if (number >= cars.Length)
            {
                Console.WriteLine("You cant park Car");
                for (int i = 0; i <cars.Length; i++)
                {
                    Console.Write(cars[i]);
                    Console.Write($" Parking Number` {i}");
                    Console.WriteLine();
                }
            }
            else if (cars[number] != null)
            {
                Console.WriteLine($"{car.Name} sir you cant park  in {number}");
                Console.WriteLine(cars[number]);
            }
            else 
            { 
                cars[number] = car;
            }
        }
        public T this[int index] 
        {
           get
            {   
                var car1 = cars[index] as T;
                return car1;
            }
        }
    }
}
