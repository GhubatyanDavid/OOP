using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_with_Array
{
    class ArrayClass<T>
    {
        public T[] array = new T[4];
        public ArrayClass()
        {
            T[] array = new T[4];
        }
        public ArrayClass(params T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public void Add(T[] array, T number)
        {
            int i = 0;
            T[] secondArray = new T[array.Length + 1];
            for (i = 0; i < array.Length; i++)
            {
                secondArray[i] = array[i];
            }
            secondArray[i] = number;
            Console.WriteLine($"{i+1}-st Array is ` {secondArray[i]}");
        }
    }
}

