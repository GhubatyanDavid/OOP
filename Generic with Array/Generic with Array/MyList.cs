using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_with_Array
{
    public class MyList<T>
    {
        public T[] array ;
        public MyList()
        {
            array = new T[0];
        }
        public MyList(params T[] array)
        {
            this.array = array;
        }
        public void Add(T number)
        {
            int i = 0;
            T[] secondArray = new T[array.Length + 1];
            for (i = 0; i < array.Length; i++)
            {
               secondArray[i] = array[i];
            }
            secondArray[i] = number;
            array = secondArray;
        }
        public void AddRange(params T[] array)
        {
            int i = 0;
            T[] secondArray = new T[this.array.Length + array.Length];
            for (; i < this.array.Length; i++)
            {
                secondArray[i] = this.array[i];
            }
            for (int j = 0; i <secondArray.Length; i++,j++)
            {
                secondArray[i] = array[j];
            }
            this.array = secondArray;
        }
    }
}

