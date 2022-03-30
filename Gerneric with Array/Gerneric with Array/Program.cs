using System;

namespace Gerneric_with_Array
{
    class MyClass<T>
    {
        public T[] array = new T[4];
        public MyClass()
        {
           T[] array = new T[4];
        }
        public MyClass(params T[] array )
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public T this[int  index]
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
        
        public void Add(T[] array,T number)
        {
            int i = 0;
            T[] secondArray = new T[array.Length + 1];
            for (i = 0; i < array.Length; i++)
            {
                secondArray[i] = array[i];
            }
            secondArray[i] = number;
            Console.WriteLine($"{i}-st Array is ` {secondArray[i]}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            MyClass<int> myClass1 = new MyClass<int>(4,2,6,8);
            //Console.WriteLine("Please Type First Number for array");
            //myClass[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Type Second Number for array");
            //myClass[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Type Third Number for array");
            //myClass[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Type Four Number for array");
            //myClass[3] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please type final Number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int index = 0; index < myClass.array.Length; index++)
            //{
            //    Console.WriteLine($"{index}-st Array is `{myClass.array[index]}");
            //}
            //myClass.Add(myClass.array, number);
        }
    }
}


