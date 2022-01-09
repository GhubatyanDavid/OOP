using System;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird("Eagle", "Bird");
            Dog firstDog = new Dog("Jacks", "Dog");
            Dog secondDog = new Dog("Doberman","Dog");
            Cat firstCat = new Cat("Hana","Cat");
            Cat secondCat = new Cat("Marusya","Cat");
            Console.WriteLine("Please Type how much animals you have");
            int number =Convert.ToInt32(Console.ReadLine());
            Zoo<Animal> zoo = new Zoo<Animal>(number);
            zoo.AddAnimals( bird, firstDog, secondDog, secondCat, firstCat) ;
            zoo.AnimalsDo();
        }
    }
}
