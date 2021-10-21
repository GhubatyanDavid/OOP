using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_in_Shop
{
    class Store
    {
        private string[] _store = new string[3];
        public string this[int index]
        {
            get
            {
                return _store[index];
            }
            set
            {
                _store[index] = value;
            }
        }
        public void IndexCall(int cheese, int meat, int vegetable)
        {
            Console.WriteLine("Please Type index of Product ` 1- 3");
            int productIndex = Convert.ToInt32(Console.ReadLine());
            if (productIndex <= _store.Length)
                Console.WriteLine($"Product name`{_store[productIndex]}");
            int[] price = new int[] { cheese, meat, vegetable };
                for (int i = 0; i < price.Length; i++)
                {
                    if (productIndex == i)
                        Console.WriteLine($"Product Price`{price[0]}");
                }
        }
        public void NameCall()
        {
            Console.WriteLine("Please Type Name of Product");
            string productName = Console.ReadLine();
            for (int i = 0; i < _store.Length; i++)
            {
                if (productName == _store[i])
                    Console.WriteLine($"We have that product name`{_store[i]}");
            }
        }

    }
}
