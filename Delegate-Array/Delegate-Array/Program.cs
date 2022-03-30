using System;

namespace Delegate_Array
{
    public delegate int ArithmeticAverage(int number);
    internal class Program
    {
        static void Main(string[] args)
        {

            ArithmeticAverage[] arithmeticAverages = new ArithmeticAverage[5];
            for (int i = 0; i < arithmeticAverages.Length; i++)
            {
                arithmeticAverages[i] = (num) => { return num; };
            }
            Console.WriteLine(GetarithmeticAverage(arithmeticAverages));
        }
        public static  double GetarithmeticAverage(ArithmeticAverage[] arithmeticAverages )
        {
            Random ran = new Random();
            double sum = 0;
            for (int i = 0; i <arithmeticAverages.Length; i++)
            {
                int random = ran.Next(5, 10);
                sum = sum + arithmeticAverages[i].Invoke(random);
                Console.WriteLine(random);
            }
            return sum/2;
        }
        
    }
}
