using System;

namespace WW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(i, i);
                Console.WriteLine("*");
                Console.SetCursorPosition(i + 8, i);
                Console.WriteLine("*");
            }
            for (int i = 4; i > 0; i--)
            {
                Console.SetCursorPosition(i+3, ((i - 4) * -1));
                Console.WriteLine("*");
                Console.SetCursorPosition(i + 11, ((i - 4) * -1));
                Console.WriteLine("*");
            }
        }
    }
}
