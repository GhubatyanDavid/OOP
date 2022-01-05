using System;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animals animals = new Animals("Tiger", "Mammal");
            Animals animals1 = new Animals("Cow", "Mammal");
            Animals animals2 = new Animals("Monkey","Mammal");
            Animals animals3 = new Animals("Eagle","Bird");
            Animals animals4 = new Animals("Lizard","Reptile");
            Zoo<Animals> zoo = new Zoo<Animals>(5);
            zoo.AddAnimal(animals, animals1, animals2, animals3, animals4);
            animals.Run(zoo.animal);
            animals.Fly(zoo.animal);
            animals.Drink(zoo.animal);
            animals.Eat(zoo.animal);
            
            
        }
    }
}
