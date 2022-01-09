using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Cat : Animal, IMammal
    {
        private string _name;
        private string _type;
        public Cat(string name, string type) : base(name, type)
        {
            _name = name;
            _type = type;
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} can Eat");
        }
        public override void Drink()
        {
            Console.WriteLine($"{_name} can Drink");
        }
        public void Run()
        {
            Console.WriteLine($"{_name} can Run");
        }
    }
}
