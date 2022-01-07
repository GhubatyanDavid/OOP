using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace CarShop
{
    internal class BicycleCollection<T> : IVehicleCollection<T> where T : Bicycle
    {
        public Bicycle[] Bicycle;

        public int Count
        {
            get { return Bicycle.Length; }
        }
        public BicycleCollection(int length)
        {
            Bicycle = new Bicycle[length];

        }
        public void AddVehicle(T bicycle, int number)
        {
            if (number >= Bicycle.Length)
            {
                Console.WriteLine("Here you cant park Bicycle please choose another");
                for (int i = 0; i < Bicycle.Length; i++)
                {
                    Console.Write(Bicycle[i]);
                    Console.Write($"Bicycle Parking Number` {i}");
                    Console.WriteLine();
                }
            }
        }
        public T this[int index]
        {
            get
            {
                var bycicle = Bicycle[index] as T;
                return bycicle;
            }
        }
    }
}


