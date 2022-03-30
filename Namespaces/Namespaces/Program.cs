using System;
using Cars;
namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type Car Brand`");
            string brand = Console.ReadLine();
            Console.WriteLine("Please Type Car Model`");
            string model = Console.ReadLine();
            Console.WriteLine("Please Type Car Year`");
            int year = Convert.ToInt32(Console.ReadLine());
            Car car = new Car(model,brand,year);
            car.CarInfo();
        }
    }
}
