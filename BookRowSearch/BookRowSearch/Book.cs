using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRowSearch
{
    class Book
    {
        public  string  BookSearch()
        {
            Console.WriteLine("Please Type Book Row Number ` ");
            int numberofRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"This is the {numberofRow}th Row");
            Console.WriteLine("Thank you!");
            return null;
        }
    }
}
