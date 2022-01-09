using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Bird :Animal, IBird
    {
        private string _name;
        private string _type;
        public Bird(string name, string type) : base(name, type)
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
        public void Fly()
        {
            Console.WriteLine($"{_name} can fly!");
        }
    }
}
