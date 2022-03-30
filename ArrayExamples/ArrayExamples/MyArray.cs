using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class MyArray<T>
    {
        public T[] array = null;
        public T[] secondArray = null;
        public int index = 0;
        public int i = 0;
        public MyArray(int length)
        {
            array = new T[length];
        }
        public void Add(T element)
        {
            array[index] = element;
            index++;
        }
        public void ArrayFromBegin(int length)
        {
            secondArray = new T[length + array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                secondArray[i] = array[i];
            }
        }
        public void AddFromEnd(T[] newArray)
        {
            for (index = array.Length; index < secondArray.Length; index++)
            {
                secondArray[index] = newArray[i];
                i++;
            }
            i = 0;
        }
        public void AddFromBegin(T[] newArray, int length)
        {
            for (i = 0; i < length; i++)
            {
                secondArray[i] = newArray[i];
            }
        }
        public void ArrayFromEnd(int length)
        {
            secondArray = new T[length + array.Length];
            index = length;
            for (int i = 0; i < array.Length; i++)
            {
                secondArray[index] = array[i];
                index++;
            }
            index = 0;
        }
        public void ArrayInMiddle(int length)
        {
            int i = 0;
            secondArray = new T[length + array.Length];
            for (i = 0; i < secondArray.Length / 2; i++)
            {
                secondArray[i] = array[i];
            }
        }
        public void AddFromMiddle(int length, T[] newArray)
        {
            int index = 0;
            int i = array.Length / 2;
            int secondIndex = array.Length / 2 + 1;
            for (; index < newArray.Length; i++)
            {
                secondArray[i] = newArray[index];
                index++;
            }
            for (; secondIndex < array.Length; i++)
            {
                secondArray[i] = array[secondIndex];
                secondIndex++;
            }

        }
    }
}

