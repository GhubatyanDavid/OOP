using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Value
{
    class Dictionary<TKey,Tvalue>
    {
       Dictionary<int, int> dictionary = new Dictionary<int, int>();
        public void AddValue()
        {
            dictionary.AddValue<int,int>(Tvalue,Tvalue);
        }
    }
}
