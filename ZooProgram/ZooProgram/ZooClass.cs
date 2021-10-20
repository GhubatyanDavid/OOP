using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProgram
{
    class Zoo
    {
        public void animals()
        {
            string[] bird = new string[3];
            bird[0] = "Eagle";
            bird[1] = "Pigeon";
            bird[2] = "Crow";
            Console.WriteLine("Birds`");
            for (int i = 0; i < bird.Length; i++)
            {
                Console.Write($" {bird[i]} ");
            }
            string[] reptile = new string[2];
            reptile[0] = "Snake";
            reptile[1] = "Lizard";
            Console.WriteLine("");
            Console.WriteLine("Reptiles`");
            for (int i = 0; i < reptile.Length; i++)
            {
                Console.Write($" {reptile[i]} ");
            }
            string[] other = new string[4];
            other[0] = "Elephant";
            other[1] = "Horse";
            other[2] = "Deer";
            other[3] = "Monkey";
            Console.WriteLine("");
            Console.WriteLine("Others`");
            for (int i = 0; i < other.Length; i++)
            {
                Console.Write($" {other[i]} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Type Category of animal");
            string animalCategory = Console.ReadLine();
            Console.WriteLine("Choose Animal to see vandaky");
            string animalName = Console.ReadLine();
            if (animalCategory == "Bird")
            {
                for (int i = 0; i < bird.Length; i++)
                {
                    if (animalName == bird[i])
                        Console.WriteLine(i+1);
                }
            }
            if(animalCategory == "Reptile")
            {
                for (int i = 0; i < reptile.Length; i++)
                {
                    if (animalName == reptile[i])
                        Console.WriteLine(i + 1);
                }
            }
            if(animalCategory=="Other")
            {
                for (int i = 0; i < other.Length; i++)
                {
                    if (animalName == other[i])
                        Console.WriteLine(i + 1);
                }
            }
            

        }
    }
}
