using System;
using System.Collections;

namespace ArrayList_with_System_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(Convert.ToInt32(Console.ReadLine()));
            arrayList.Add(Convert.ToInt32(Console.ReadLine()));
            arrayList.Add((object)Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine((int)arrayList[i]);
        }
    }
    }

