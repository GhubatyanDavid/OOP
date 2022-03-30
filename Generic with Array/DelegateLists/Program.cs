using Generic_with_Array;
using System;

namespace DelegateLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            MyList<int> mylist = new MyList<int>(2,3,6);
            int[] array = mylist.GetArray(number);
        }
    }
}
