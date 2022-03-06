using System;

namespace PricesinShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] shop = new string[5] { "Gucci", "Addidas", "Toyota Motors", "Ikea", "Puma" };
            Console.WriteLine("We have only five shops`");
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine($"Shop name`{shop[i]}");
            }
            Console.WriteLine("Please type Shop name `");
            string shopName = Console.ReadLine();
            Console.WriteLine("Please type Product name`");
            string productName = Console.ReadLine();
            Console.WriteLine("Please add price`");
            int money = Convert.ToInt32(Console.ReadLine());
            Price price = new Price(productName,shopName,money);
            for (int i = 0; i < shop.Length; i++)
            {
                if(shop[i] == shopName)
                {
                    Console.WriteLine(price.ToString());
                    break;
                }
                else if(i == shop.Length -1 )
                {
                    try
                    {
                        throw new Exception(); 
                    }
                    catch
                    {
                        Console.WriteLine("Error wrong shop name!!");
                        break;
                    }
                }
            }
        }
    }
}
