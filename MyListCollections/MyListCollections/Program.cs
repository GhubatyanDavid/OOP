using System;

namespace MyListCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[4];
            MyList<string> list = new MyList<string>(array);
            list.Add("156156");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
