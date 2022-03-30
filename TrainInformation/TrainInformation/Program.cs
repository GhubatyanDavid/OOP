using System;

namespace TrainInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Train train1= new Train("USA",45,20);
            Train train2 = new Train("Russia", 18, 8);
            Train train3 = new Train("Indonesia", 14, 3);
            Train train4 = new Train("Armenia", 77, 1);
            Train train5 = new Train("Georgia", 62, 6);
            Train train6 = new Train("Kazakstan", 4, 11);
            Train train7 = new Train("France", 58, 20);
            Train train8 = new Train("Canada", 96, 24);
            Train[] array = new Train[8] { train1, train2, train3, train4, train5, train6, train7, train8 };
            Console.WriteLine("Please Type of Number Train!");
            int trainNumber = Convert.ToInt32(Console.ReadLine());
            train.UserOutput(trainNumber, array);
        }
    }
}
