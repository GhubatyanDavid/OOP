using System;

namespace CarProgram
{
    class Car
    {
        private string _brand;
        private string _model;
        private int _maxspeed;
        public string brand
        {
            set
            {
                _brand = value;
            }
            get
            {
                return _brand;
            }

        }
        public string model
        {
            set
            {
                _model = value;
            }
            get
            {
                return  _model;
            }
        }
        public int  Maxspeed()
        {
            if(brand=="Mercedes")
            {
                _maxspeed = 240;
            }
            if(brand == "Bmw")
            {
                _maxspeed = 280;
            }
            if (brand == "Toyota")
            {
                _maxspeed = 180;
            }
            else
                Console.WriteLine("Car crashed!!!   speed is to high");
            return _maxspeed;
        }
        public int Carstarting()
        {
            for (int i = 0; i < _maxspeed; i++)
            {
                Console.WriteLine($"Car Speed is`{i}");
            }
            Console.WriteLine("Car crashed!!! speed is to high");
            return _maxspeed;
        }
        
      
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car instance = new Car();
            Console.WriteLine("Please Choose and Type Car Brand`(examples` Mercedes,Bmw,Toyota)");
            instance.brand = Console.ReadLine();
            Console.WriteLine("Please Type Car Model`");
            instance.model = Console.ReadLine();
            Console.WriteLine("!!Wait car is starting");
            instance.Maxspeed();
            instance.Carstarting();
            Console.ReadKey();
            


        }
    }
}
