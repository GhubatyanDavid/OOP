using System;

namespace Delegate_Calculator
{
    internal class Program
    {
        public delegate int Calculator(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type First Number`");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type Second Number`");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type The Arithmmetic Type example` + - / *");
            char arithmeticOperator = Convert.ToChar(Console.ReadLine());
            Calculator calculator;
            int result = 0;
            if (arithmeticOperator == '+')
            {
                calculator = delegate (int a, int b) { return a + b; };
                result = calculator.Invoke(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} {arithmeticOperator} {secondNumber} = {result}");
            }
            if(arithmeticOperator == '-')
            {
                calculator = (a, b) => { return a - b; };
                result = calculator.Invoke(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} {arithmeticOperator} {secondNumber} = {result}");
            }
            if(arithmeticOperator == '*')
            {
                calculator = (a, b) => { return a * b; };
                result = calculator.Invoke(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} {arithmeticOperator} {secondNumber} = {result}");
            }
            if(arithmeticOperator == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error cant Divine number to Zero!!");
                }
                else if(secondNumber != 0)
                {
                    calculator = (a, b) => { return a / b; };
                    result = calculator.Invoke(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} {arithmeticOperator} {secondNumber} = {result}");
                }
            }
            else
            Console.WriteLine("You typed wrong number or arithmetic operation please try again!");
            
        }
    }
}
