using System;

namespace Gerneric_with_Array
{
    class MyClass<T>
    {
        public int[] array = new int[4];
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Array()
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"{index}-st Array is `{array[index]}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine("Please Type First Number for array");
            myClass[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type Second Number for array");
            myClass[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type Third Number for array");
            myClass[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Type Four Number for array");
            myClass[3] = Convert.ToInt32(Console.ReadLine());
            myClass.Array();
        }
    }
}


