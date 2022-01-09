using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo<T> where T : Animal
    {
        public T[] animals;
        public Zoo(int length)
        {
             this.animals = new T[length];
        }
        public void AddAnimals(params T[] animals)
        {
            this.animals = animals;
        }
        public T this[int index]
        {
            get
            {
                    var animals = this.animals[index] as T;
                    return animals;
            }
        }
        public void AnimalsDo()
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if(animals[i] is Bird)
                {
                    Bird bird = animals[i] as Bird;
                    bird.Fly();
                    bird.Drink();
                    bird.Eat();
                }
                if(animals[i] is Dog)
                {
                    Dog dog = animals[i] as Dog;
                    dog.Run();
                    dog.Eat();
                    dog.Drink();
                }
                if(animals[i] is Cat)
                {
                    Cat cat = animals[i] as Cat;
                    cat.Run();
                    cat.Eat();
                    cat.Drink();
                }
            }
        }

    }
}