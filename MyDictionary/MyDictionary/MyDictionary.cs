using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey,TValue> : IEnumerable , IEnumerator  where TKey : class
    {
        Element<TKey,TValue>[] elementArray = null;
        public MyDictionary(Element<TKey,TValue>[] element)
        {
            elementArray = element;
        }
        public void Add(Element<TKey,TValue>[] element)
        {
            for (int i = 0; i < element.Length; i++)
            {
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[i].key == element[j].key & i!=j)
                    {
                        throw new Exception("Sorry An item with the same key has already been added!!");
                    }
                    else
                    {
                        elementArray[i] = element[i];
                    }
                }
                
            }
        }
        int  position = 0;
        public Element<TKey,TValue> this[int index]
        {
            get { return elementArray[index]; }
            set { elementArray[index] = value; }
        }
        public bool MoveNext()
        {
            if (position < elementArray.Length)
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
            get
            {
                return elementArray[position-1];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
