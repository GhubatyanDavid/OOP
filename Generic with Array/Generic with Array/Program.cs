using System;

namespace Generic_with_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type the number");
            int number = Convert.ToInt32(Console.ReadLine());
            ArrayClass<int> arrayClass = new ArrayClass<int>();
            ArrayClass<int> arrayClass1 = new ArrayClass<int>(4, 2, 6, 8);
            arrayClass.Add(arrayClass.array, number);
        }
    }
}
