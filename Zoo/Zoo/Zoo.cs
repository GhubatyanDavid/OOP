using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo<T> where T : Animals
    {
        public Animals[] animal;
        public Zoo(int length)
        {
             this.animal = new Animals[length];
        }
        public void AddAnimal(Animals animal,Animals animal1,Animals animal2,Animals animal3,Animals animal5)
        {
            this.animal[0] = animal;
            this.animal[1] = animal1;
            this.animal[2] = animal2;
            this.animal[3] = animal3;
            this.animal[4] = animal5;
        }
        public T this[int index]
        {
            get
            {
                    var animals = animal[index] as T;
                    return animals;
            }
        }

    }
}
