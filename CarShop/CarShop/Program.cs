using System;

namespace CarShop
{
    internal class Program
    {
        public static void CheckClass<T>(IVehicleCollection<T> vehicleCollection)
        {
            CarCollection<Car> carCollection = vehicleCollection as CarCollection<Car>;
            if(carCollection != null)
            {
                Console.WriteLine("This is CarCollection");
                PrintCar(carCollection);
            }
            BicycleCollection<Bicycle> bicycleCollection = vehicleCollection as BicycleCollection<Bicycle>;
            if(bicycleCollection != null)
            {
                Console.WriteLine("This is BicycleCollection");
                PrintCar(bicycleCollection);
            }
        }
        public static void PrintCar<T>(IVehicleCollection<T> vehicleCollection)
        {
            for (int i = 0; i < vehicleCollection.Count; i++)
            {
                T vehicle = vehicleCollection[i];
                Console.WriteLine(vehicle);
            }
        }
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>(8);
            Car car = new Car("Mercedes E500", "1995Y","Karen", "Minasyan");
            carCollection.AddVehicle(car,5);
            //Console.WriteLine(car);
            Car car2 = new Car("Toyota Corolla", "2007Y","Suren","Vanyan");
            carCollection.AddVehicle(car2, 4);
            BicycleCollection<Bicycle> bicycle = new BicycleCollection<Bicycle>(4);
            Bicycle bicycle1 = new Bicycle("Arlyonog", "1888");
            Bicycle bicycle2 = new Bicycle("BMX", "2000");
            bicycle.AddVehicle(bicycle2, 4);
            bicycle.AddVehicle(bicycle1, 1);
            CheckClass(carCollection);
            CheckClass(bicycle);
        }
       
    }
}
