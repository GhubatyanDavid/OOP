using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type Number`");
            int number = 0;
            int secondNumber;
            bool intCheck = int.TryParse(Console.ReadLine(), out number);
            if(intCheck == true)
            {
                int reverseNumber = 0;
                int inputNumber = number;
                for (; number > 0;)
                {
                    secondNumber = number % 10;
                    reverseNumber = reverseNumber * 10 + secondNumber;
                    number = number / 10;
                }
                Console.WriteLine("Input number` {0} , Reverse number` {1}", inputNumber, reverseNumber);
            }
            else
            {
                Console.WriteLine("Sorry,please type number!!");
            }
            
        }
    }
}
