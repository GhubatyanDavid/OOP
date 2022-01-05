using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animals:Animalsdoing,IBirds,IMammals
    {
        private string _name;
        private string _animalType;
        public Animals(string name,string animalType)
        {
            _name = name;
           _animalType = animalType;
        }
        public override void Eat(Animals[] animal)
        {
            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"{animal[i]._name} can eat :)");
            }
            
        }
        public override void Drink(Animals[] animal)
        {
            for (int i = 0; i <animal.Length; i++)
            {
                Console.WriteLine($"{animal[i]._name} can Drink :)");
            }
        }
        public void Fly(Animals[] animal)
        {
            for (int i = 0; i < animal.Length; i++)
            {
                if (animal[i]._animalType == "bird")
            {
                    Console.WriteLine($"Only {animal[i]._name} Can Fly :)");
                }
                else
                {
                    Console.WriteLine($"{animal[i]._name} cant fly!");
                }
            }
        }
        public void Run(Animals[] animal)
        {
            for (int i = 0; i < animal.Length; i++)
            {
                if (animal[i]._animalType != "bird")
                {
                    Console.WriteLine($"Only {animal[i]._name} Can Run :)");
                }
                else if (animal[i]._animalType == "bird")
                {
                    Console.WriteLine($"{animal[i]._name} cant Run!");
                }
            }
        }
    }
}
