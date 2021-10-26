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

            for (int i = 0; i < array.Length; i++)
            {
                int minNumber = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    if (minNumber < array[j])
                    {
                        minNumber = array[j];
                        array[j] = array[i];
                        array[i] = minNumber;
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
