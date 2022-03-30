using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListCollections
{
    internal class MyList<T> : IEnumerable, IEnumerator
    {
        public int curentIndex = 0;
        public T[] array;
        public MyList(T[] array)
        {
            this.array = array;
        }
        public void Add(T arrayElement)
        {
            if (curentIndex >= array.Length)
            {
                T[] secondArray = new T[array.Length * 2];
                for (curentIndex = 0; curentIndex < array.Length; curentIndex++)
                {
                    secondArray[curentIndex] = array[curentIndex];
                }
                secondArray[curentIndex] = arrayElement;
                array = secondArray;
            }
            else
            {
                array[curentIndex] = arrayElement;
            }
        }
        public T this[int index]
        {
            get
            { return array[index]; }
            set
            { array[index] = value; }
        }
        int position = 0;
        public bool MoveNext()
        {
            if (position < array.Length)
            {
                position++;
                return true;
            }
            else
            { 
                return false;
            }
        }
        public void Reset()
        {
            position = 0;
        }
        public object Current
        {
            get { return array[position-1]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

    }
}
