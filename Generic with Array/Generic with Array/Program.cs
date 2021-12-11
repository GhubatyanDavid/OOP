using System;

namespace Generic_with_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Please Type the number");
           // int number = Convert.ToInt32(Console.ReadLine());
            MyList<int> arrayClass1 = new MyList<int>(4, 2, 6, 8);
            //arrayClass1.Add( number);
            arrayClass1.AddRange(10,12,13); 
            for (int i = 0; i < arrayClass1.array.Length; i++)
            {
                Console.WriteLine(arrayClass1.array[i]);
            }
            
        }
    }
}
