using System;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> myArray = new MyArray<int>(5);
            myArray.Add(2);
            myArray.Add(3);
            myArray.Add(4);
            myArray.Add(5);
            myArray.Add(6);
            Console.WriteLine("Please Type length of your numbers!");
            int[] newArray = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Please type numbers");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("If you want add more elements from the end please type '1' !");
            Console.WriteLine("If you want add more elements from the begining please type '2'!");
            Console.WriteLine("If you want add more elements from the middle please type '3'!");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                myArray.ArrayFromBegin(newArray.Length);
                myArray.AddFromEnd(newArray);
            }
            else if (number == 2)
            {
                myArray.ArrayFromEnd(newArray.Length);
                myArray.AddFromBegin(newArray, newArray.Length);
            }
            else if (number == 3)
            {
                myArray.ArrayInMiddle(newArray.Length);
                myArray.AddFromMiddle(newArray.Length, newArray);
            }
            for (int i = 0; i < myArray.secondArray.Length; i++)
            {
                Console.WriteLine(myArray.secondArray[i]);
            }
        }
    }
}
