using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringColor
{
    static class PrintString
    {
        public static void Print(string stroka,string colorName)
        {
            if( colorName == "Blue" )
            {
                Console.ForegroundColor = (ConsoleColor)EnumType.Blue;
            }
            if (colorName == "Red")
            {
                Console.ForegroundColor = (ConsoleColor)EnumType.Red;
            }
            if (colorName == "Yellow")
            {
                Console.ForegroundColor = (ConsoleColor)EnumType.Yellow;
            }
            if (colorName == "Green")
            {
                Console.ForegroundColor = (ConsoleColor)EnumType.Green;
            }
            if (colorName == "White")
            {
                Console.ForegroundColor = (ConsoleColor)EnumType.White;
            }
            Console.WriteLine(stroka);
        }
    }
    
}
