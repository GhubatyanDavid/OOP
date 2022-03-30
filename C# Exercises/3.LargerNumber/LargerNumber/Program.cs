using System;

namespace LargerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a > b & a > c)
            {
                Console.WriteLine($"Largest number`{a}");
            }
            else if(b > a & b > c)
            {
                Console.WriteLine($"Largest number`{b}");
            }
            else
            {
                Console.WriteLine($"Largest number`{c}");
            }
        }
    }
}
