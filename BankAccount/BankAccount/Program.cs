using System;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Type your bank account number!");

                int accountNumber = Convert.ToInt32(Console.ReadLine());
                int accountMoney = 0;
                Console.WriteLine("Please Type How much money you want add your card");
                int money = Convert.ToInt32(Console.ReadLine());
                if (accountNumber == 1111)
                {
                    accountMoney = 1000;
                }
                else if (accountNumber == 2222)
                {
                    accountMoney = 400;
                }
                Director director = new Director(new Account(accountMoney, accountNumber));
                Manager manager = new Manager(new Account(accountMoney, accountNumber));
                if (accountNumber == 1111)
                {
                    director.Account.notify += director.Handler;
                    director.Account.AddMoney(money);
                }
                else if (accountNumber == 2222)
                {
                    manager.Account.notify += manager.Handler;
                    manager.Account.AddMoney(money);
                }
                else
                {
                    Console.WriteLine("Wrong Account number.Please try again!");
                }
            }
        }

    }
}
