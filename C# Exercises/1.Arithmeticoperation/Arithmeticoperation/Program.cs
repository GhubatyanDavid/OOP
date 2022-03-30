using System;

namespace Arithmeticoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            Console.WriteLine("Please type number");
            string userNumber = Console.ReadLine();
            int number;
            bool numberCheck = int.TryParse(userNumber, out number);
            Console.WriteLine("Please type degree of number");
            string userNumber2 = Console.ReadLine();
            int degree;
            bool degreeCheck = int.TryParse(userNumber2, out degree);
            if (degreeCheck == true && numberCheck == true)
            {
                for (int i = 0; i < degree; i++)
                {
                    sum = sum * number;
                }
                Console.WriteLine($"{number} Degree {degree} will be `{sum}");
            }
            else
            {
                Console.WriteLine("Error please type numbers");
            }
        }
    }
}
