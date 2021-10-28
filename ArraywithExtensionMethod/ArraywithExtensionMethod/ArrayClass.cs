using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraywithExtensionMethod
{
    static class ArrayClass
    {
        public static int Method(this int[] value)
        {
            int[] array = value;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-(1+i); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return array[5];
        }
    }
}
