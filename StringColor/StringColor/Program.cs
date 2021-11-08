using System;

namespace StringColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = Enum.GetValues(typeof(EnumType));
            Console.WriteLine("Please Type the Line of words`");
            string stroka = Console.ReadLine();
            Console.WriteLine("Please type Color of Line(example` White,Yellow,Blue,Red)");
            int colorNumber =Convert.ToInt32(Console.ReadLine());
            object color = null ;
            for (int i = 0; i < array.Length; i++)
            {
                if (colorNumber == i)
                {
                    color = array.GetValue(i);
                    break;
                }
            }
            String colorName = ((EnumType)color).ToString();
            PrintString.Print(stroka, colorName);
            
        }
    }
}
