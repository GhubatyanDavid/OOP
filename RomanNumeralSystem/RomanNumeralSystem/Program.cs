using System;
using System.Collections.Generic;

namespace RomanNumeralSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, string>()
            {
                {1,"I"},
                {5,"V"},
                {10,"X"},
                {50,"L"},
                {100,"C"},
            };
            Console.WriteLine("Please type number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 3)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(numbers[1]);
                }
            }
            else if (x == 4)
            {
                Console.WriteLine(numbers[1] + numbers[5]);
            }
            else if (x > 5 && x <= 8)
            {
                if (x == 5)
                {
                    Console.WriteLine(numbers[5]);
                }
                else
                {
                    Console.Write(numbers[5]);
                    for (int i = 5; i < x; i++)
                    {
                        Console.Write(numbers[1]);
                    }
                }
            }
            else if (x > 8 && x<=30)
            {
                if(x == 9)
                {
                    Console.WriteLine(numbers[1]+numbers[10]);
                }
                else if(x==10)
                {
                    Console.WriteLine(numbers[10]);
                }
                else
                {
                    for (int i = 9; i < x; i=i+10)
                    {
                        Console.Write(numbers[10]);
                    }
                }
            }
        }
    }
}
