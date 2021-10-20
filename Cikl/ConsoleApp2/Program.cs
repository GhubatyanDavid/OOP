using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Напишите программу, в которой получите от пользователя два целых числа.
			Используя цикл выведите все нечетные числа, расположенные между введенными числами. */
			int firstnumber = Convert.ToInt32(Console.ReadLine());
			int secondnumber = Convert.ToInt32(Console.ReadLine());
			while (firstnumber < secondnumber)
			{
				int first = firstnumber++;
				if (first % 2 == 0)
				{
					Console.WriteLine(first++);
				}


			}

		}
	}
}
