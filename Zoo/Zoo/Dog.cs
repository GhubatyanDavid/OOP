using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Dog:Animal , IMammal
    {
        private string _name;
        private string _type;
        public Dog(string name,string type) : base(name,type)
        {
            _name = name;
            _type = type;
        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} can eat!");
        }
        public override void Drink()
        {
            Console.WriteLine($"{_name} can Drink!");
        }
        public  void  Run()
        {
            Console.WriteLine($"{_name} can Run!");
        }
    }
}
