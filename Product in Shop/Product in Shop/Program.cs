using System;

namespace Product_in_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            article.Cheese = "This is Great Cheese";
            article.CheesePrice = 5;
            article.Meat = "The Meat is Delicious";
            article.MeatPrice = 7;
            article.SuperShop = "Super Shop";
            article.Vegetables = "Vegetables oh so Delicious";
            article.VegetablesPrice = 2;
            Store store = new Store();
            store[0] = article.Cheese;
            //store[1] = article._meat;
            //store[2] = article._vegetables;
            store.Method();
            

        }
    }
}
