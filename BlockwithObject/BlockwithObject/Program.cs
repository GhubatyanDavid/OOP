using System;

namespace BlockwithObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block(10, 5, 6, 9);
            Console.WriteLine(block.ToString());
        }
    }
}
