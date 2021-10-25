using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    static class Calculator
    {
        private static int _firstNumber;
        private static int _secondNumber;
        private static string _arithmeticOperation;
        public static int FirstNumber
        {
            get { return _firstNumber; }
            set { _firstNumber = value; }
        }
        public static int SecondNumber
        {
            get { return _secondNumber; }
            set { _secondNumber = value; }
        }
        public static string ArithmeticOperation
        {
            get { return _arithmeticOperation; }
            set { _arithmeticOperation = value; }
        }
        public static void DeterminedOperation()
        {
            if (_arithmeticOperation == "+")
            {
                int sum = _firstNumber + _secondNumber;
                Console.WriteLine($"{_firstNumber} + {_secondNumber} = {sum}");
            }
            else if (_arithmeticOperation == "-")
            {
                int sum = _firstNumber - _secondNumber;
                Console.WriteLine($"{_firstNumber} - {_secondNumber} = {sum}");
            }
            else if (_arithmeticOperation == "/")
            {
                if (_secondNumber == 0)
                {
                    Console.WriteLine("The number is not divisible by zero");
                }
                else
                {
                    int sum = _firstNumber + _secondNumber;
                    Console.WriteLine($"{_firstNumber} / {_secondNumber} = {sum}");
                }
            }
            else if (_arithmeticOperation == "*")
            {
                int sum = _firstNumber + _secondNumber;
                Console.WriteLine($"{_firstNumber} * {_secondNumber} = {sum}");
            }
            else
            {
                Console.WriteLine("Error 404! Please Try again!");
            }
        }
    }
}
