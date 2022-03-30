using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
     struct Element<TKey,TValue>
    {
        public TKey key;
        public TValue value;
        public Element(TKey key,TValue value)
        {
            this.key = key;
            this.value = value;
        }
        //public TKey Key
        //{
        //    get { return key; }
        //    set { key = value; }
        //}
        //public TValue Value
        //{
        //    get { return value; }
        //    set { this.value = value; }
        //}
    }
}
