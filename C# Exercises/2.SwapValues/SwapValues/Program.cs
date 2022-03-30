using System;

namespace SwapValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Please type two numbers`");
            string first = Console.ReadLine();
            bool firstCheck = int.TryParse(first, out firstNumber);
            string second = Console.ReadLine();
            bool secondCheck = int.TryParse(second, out secondNumber);
            if(firstCheck == true && secondCheck == true)
            {
                firstNumber ^= secondNumber;
                secondNumber ^= firstNumber;
                firstNumber ^= secondNumber;
                Console.WriteLine($"First number will be`{firstNumber},Second` {secondNumber}");
            }
            else
            {
                Console.WriteLine("Error, please type numbers");
            }
        }
    }
}
