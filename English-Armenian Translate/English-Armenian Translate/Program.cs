using System;

namespace English_Armenian_Translate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstWord = new { english = "Book", armenian = "Girq " };
            var secondWord = new { english = "Phone", armenian = "Heraxos" };
            var thirdWord = new { english = "Key", armenian = "Banali" };
            var fourWord = new { english = "Car", armenian = "Meqena" };
            var fiveWord = new { english = "Cat", armenian = "Katu" };
            var sixWord = new { english = "Dog", armenian = "Shun" };
            var sevenWord = new { english = "Room", armenian = "Senyak" };
            var eightWord = new { english = "House", armenian = "Tun" };
            var nineWord = new { english = "Word", armenian = "Ashxarh" };
            var tenWord = new { english = "Programer", armenian = "Cragravorox" };
            dynamic[] word = new [] { firstWord, secondWord, thirdWord, fourWord, fiveWord, sixWord, sevenWord, eightWord };
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("English`{0}  -  Armenian`{1}", word[i].english, word[i].armenian);
            }
        }
    }
}
