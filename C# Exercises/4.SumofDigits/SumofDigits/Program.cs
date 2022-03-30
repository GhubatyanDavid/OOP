using System;

namespace SumofDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int divider ;
            for (; number > 0;)
            {
                divider = number % 10;
                sum = sum + divider;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
