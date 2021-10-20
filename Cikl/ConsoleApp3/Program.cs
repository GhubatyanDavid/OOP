using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			int b = 1;
			int sum;
			while (a > b) 
			{
				int c = a--;
				int z = c * a;
				Console.WriteLine($"{c}*{a}={z}");
				sum = z*c--;
				Console.WriteLine(sum);

			}


		}
	}
}
