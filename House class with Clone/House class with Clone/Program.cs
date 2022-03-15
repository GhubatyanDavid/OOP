using System;

namespace House_class_with_Clone
{
    internal class Program:House
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.HouseAdress = "Muratsan 1";
            house.HouseNumber = 14;
            Program program = new Program();
            Console.WriteLine($"Original Program {house.ToString()}");
            Program cloneProgram = program.MemberwiseClone() as Program;
            Console.WriteLine($"Clone Program {house.ToString()}");

        }
    }
}
