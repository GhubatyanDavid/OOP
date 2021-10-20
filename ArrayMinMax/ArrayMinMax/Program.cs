using System;

namespace ArrayMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            Console.WriteLine("Please type  Number`");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type next  Number`");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type next Number`");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type next Number`");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type next Number`");
            array[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type next Number`");
            array[5] = Convert.ToInt32(Console.ReadLine());
            array.MinMax();
            array.Sum();
            array.ArithmeticElements();
            array.OddValue();
        }
    }
}
