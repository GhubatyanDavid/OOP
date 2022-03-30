using System;

namespace PoygonArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number`");
            string input = Console.ReadLine();
            bool numberCheck = int.TryParse(input, out int number);
            if(numberCheck == true)
            {
                if(number != 0)
                {
                    int sum = Convert.ToInt32(Math.Pow(number,2)) + Convert.ToInt32(Math.Pow(number-1, 2));
                    Console.WriteLine($"Polygon area length`{sum}");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            { 
                Console.WriteLine("Please type numbers");
            }
                
        }
    }
}
