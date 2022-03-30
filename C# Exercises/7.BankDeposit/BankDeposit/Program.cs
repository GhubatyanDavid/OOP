using System;

namespace BankDeposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank!");
            Console.WriteLine("Please type the amount of the deposit in the bank");
            string amount = Console.ReadLine();
            int depositAmount;
            bool amountCheck = int.TryParse(amount, out depositAmount);
            if(amountCheck == true)
            {
                int firstPercent = depositAmount * 5 / 100;
                int secondPercent = depositAmount * 7 / 100;
                int thirdPercent = depositAmount * 10 / 100;
                if(depositAmount < 100)
                {
                    int oneYearPercent =  firstPercent;
                    int fiveYearPercent = 5 * firstPercent;
                    int tenYearPercent = 10 * firstPercent;
                    Console.WriteLine($"1 year percent will be`{oneYearPercent} \n5 year percent will be`{fiveYearPercent} \n10 year percent will be`{tenYearPercent}");
                    Console.WriteLine($"1 year Money will be`{depositAmount+oneYearPercent} \n5 year Money will be`{depositAmount+fiveYearPercent} \n10 year will be`{depositAmount+tenYearPercent}");
                }
                if(depositAmount>=100 & depositAmount<200 )
                {
                    int oneYearPercent = secondPercent;
                    int fiveYearPercent = 5 * secondPercent;
                    int tenYearPercent = 10 * secondPercent;
                    Console.WriteLine($"1 year percent will be`{oneYearPercent} \n5 year percent will be`{fiveYearPercent} \n10 year percent will be`{tenYearPercent}");
                    Console.WriteLine($"1 year Money will be`{depositAmount + oneYearPercent} \n5 year Money will be`{depositAmount + fiveYearPercent} \n10 year will be`{depositAmount + tenYearPercent}");
                }
                if(depositAmount>=200)
                {
                    int oneYearPercent = thirdPercent;
                    int fiveYearPercent = 5 * thirdPercent;
                    int tenYearPercent = 10 * thirdPercent;
                    Console.WriteLine($"1 year percent will be`{oneYearPercent} \n5 year percent will be`{fiveYearPercent} \n10 year percent will be`{tenYearPercent}");
                    Console.WriteLine($"1 year Money will be`{depositAmount + oneYearPercent} \n5 year Money will be`{depositAmount + fiveYearPercent} \n10 year will be`{depositAmount + tenYearPercent}");
                }
            }
            else
            {
                Console.WriteLine("Something wrong please type correct numbers!");
            }
        }
    }
}
