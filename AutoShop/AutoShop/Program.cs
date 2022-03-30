using System;
using System.Collections.Generic;
using System.Linq;
namespace AutoShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var car = new List<Car>
            {
                new Car
                {
                    carName = "Mercedes",
                    carModel = "E200",
                    carYear = 1999,
                },
                new Car
                {
                    carName = "Toyota",
                    carModel = "Corolla",
                    carYear = 2008,
                },
                new Car
                {
                    carName = "BMW",
                    carModel = "x6",
                    carYear = 2006,
                }
            };
            var cars = from Car in car
                       select new
                       {
                           carName = Car.carName,
                           carModel = Car.carModel,
                           carYear = Car.carYear,
                       };
            foreach (var item in cars)
            {
                Console.WriteLine("Car Model`{0} Car Name`{1} Car Year`{2}", item.carModel, item.carName, item.carYear);
            }
            Console.WriteLine("Please type 1,2 or 3 for choose the car");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Type your Surname");
            string surName = Console.ReadLine();
            Console.WriteLine("Please type your Phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            var buyer = new List<Buyer>
            {
                new Buyer
                {
                    name = name,
                    surName = surName,
                    phoneNumber = phoneNumber,
                }
            };
            var buyerInfo = from Buyer in buyer
                            select new

                            {
                                name = Buyer.name,
                                surName = Buyer.surName,
                                phoneNumber = Buyer.phoneNumber,
                            };
            foreach (var item in buyerInfo)
            {
                Console.WriteLine("Buyer Name`{0} , Buyer Surname`{1} , Buyer Telephone Number`{2}", item.name, item.surName, item.phoneNumber);
            }
        }
        
    }
}

