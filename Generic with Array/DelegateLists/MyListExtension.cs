using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_with_Array;

namespace DelegateLists
{
    internal static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list,T number)
        {
            list.Add(number);
            return list.array;
        }
    }
}
