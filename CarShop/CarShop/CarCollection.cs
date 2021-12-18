using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class CarCollection<T>  : IVehicleCollection<T> where T : Car
     {
        private Car[] _cars;

        public int Count
        {
            get { return _cars.Length; }
        }
        public CarCollection(int length)
        {
            _cars = new Car[length];

        }
        public void AddCar(T car,int number)
        {
            if (number >= _cars.Length)
            {
                Console.WriteLine("Axper jan tex chka kangnelu");
                for (int i = 0; i <_cars.Length; i++)
                {
                    Console.Write(_cars[i]);
                    Console.Write($" Parking Number` {i}");
                    Console.WriteLine();
                }
            }
            else if (_cars[number] != null)
            {
                Console.WriteLine($"{car.Name} jan tex chka kangnelu {number}-i tak");
                Console.WriteLine(_cars[number]);
            }
            else 
            { 
                _cars[number] = car;
            }
        }
        public T this[int index] 
        {
           get
            {   
                //Old Version`
                //if (_cars[index] is T)                
                //    return (T)_cars[index];
                //else
                //    return null;
                //if (_cars[index] is T car)
                //    return car;
                //else
                //    return null;
                var car1 = _cars[index] as T;
                return car1;

            }
        }
    }
}
