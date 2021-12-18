using System;

namespace CarShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>(8);
            Car car = new Car("Mercedes E500", "1995Y","Karen", "Minasyan");
            carCollection.AddCar(car,5);
            Console.WriteLine(car);
            Car car2 = new Car("Toyota Corolla", "2007Y","Suren","Vanyan");
            carCollection.AddCar(car2, 5);
            long a = 10;
            int b = (int)a;
            //hecanivneri kalekcya,program classi mej metod vor@ vorpes parametr stanalu e IVehicleCollection
            //IVEHICLE i mej avelacnel proprty vor@ miayn uni get , vor@ veradarcnelu e ayd collection
            //ogtagorcel as kam is
            //ete CarCollection e handisanum apa gri CarCollection evb ayd car collection meji sax car ery tpi nuyn@ nayev bicycle i hamar
        }
    }
}
