using System;

namespace NaturalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type number!");
            int number = Convert.ToInt32(Console.ReadLine());
            int divider = 0;
            int secondNumber = 2;
            int[] array = new int[number];
            for (int i = 0; secondNumber<number; i++)
            {
                array[i] = secondNumber;
                secondNumber++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(number % array[i] == 0 && number % array[i] != number)
                {
                    divider = array[i];
                    break;
                }
            }
            Console.WriteLine(divider);
        }
    }
}
