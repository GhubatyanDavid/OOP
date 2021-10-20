using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Напишите программу, в которой получите от целое число и используя циклическую
				конструкцию выведите на экран консоли все числа от введенного и до нуля
				включительно.*/
			int number = Convert.ToInt32(Console.ReadLine());
			while(number>-1)
				{
				Console.WriteLine(number);
				number--;
				break;
			}

		}
	}
}
