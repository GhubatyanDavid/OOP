using System;

namespace HaveZeroOrNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] numbers = new byte[5];
            int dontHaveZero = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please type {i + 1} number");
                numbers[i] = Convert.ToByte(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine($"Yes we have zero,you add zero in `{i + 1} , if you want see your typed numbers please type 1 if want exit type 2 ");
                    if (Convert.ToByte(Console.ReadLine()) == 1)
                    {
                        ShowNumbers(numbers);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                dontHaveZero = numbers[i] * numbers[i++];
            }
            DontHaveZero(dontHaveZero, numbers);
        }
        public static void ShowNumbers(byte[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static void DontHaveZero(int dontHaveZero,byte[] numbers)
        {
            if(dontHaveZero != 0)
            {
                Console.WriteLine("No we dont have zero,if you want see your typed numbers please type 1 if want exit type 2 ");
                if (Convert.ToByte(Console.ReadLine()) == 1)
                {
                    ShowNumbers(numbers);
                }
            }
        }
    }
}
