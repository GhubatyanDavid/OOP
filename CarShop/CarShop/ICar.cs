using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal interface ICar
    {
        public static void AddDeleteCar()
        {
            Car car = new Car("Mercedes E500", "1995Y");
            Car car1 = new Car("BMW E46", "2003Y");
            Car car2 = new Car("Toyota Corolla", "2007Y");
            Car car3 = new Car("Mercedes C180", "199Y");
            Console.WriteLine("Please type car model.");
            string carName = Console.ReadLine();
            Console.WriteLine("Please type car year.");
            string carYear = Console.ReadLine();
            Car car4 = new Car(carName, carYear);
            CarCollection<Car> carCollection = new CarCollection<Car>(car, car1, car2, car3, car4);
            for (int i = 0; i < carCollection.Car.Length; i++)
            {
                Console.WriteLine(carCollection.Car[i]);
            }
            Console.WriteLine("If you want 'delete' Cars please type delete if not just type anything");
            string delete = Console.ReadLine();
            if (delete == "delete")
            {
                for (int i = 0; i < carCollection.Car.Length; i++)
                {
                    carCollection.Car[i] = null;
                    Console.WriteLine(carCollection.Car[i]);
                }
            }
            else
                Console.WriteLine("Bye!!");
        }
    }
}
