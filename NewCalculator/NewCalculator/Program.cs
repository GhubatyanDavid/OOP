using System;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type First Number`");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type Second Number`");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type The Arithmetic operation`'+' '-' '/' '*'");
            string arithmeticOperation = Console.ReadLine();
            Calculator.FirstNumber=firstNumber;
            Calculator.SecondNumber = secondNumber;
            Calculator.ArithmeticOperation = arithmeticOperation;
            Calculator.DeterminedOperation();
        }
    }
}
