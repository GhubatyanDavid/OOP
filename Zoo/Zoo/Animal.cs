using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        private string _name;
        private string _animalType;
        public Animal(string name, string animalType)
        {
            _name = name;
            _animalType = animalType;
        }
        public abstract void Eat();
        public abstract void Drink();
    }
}
