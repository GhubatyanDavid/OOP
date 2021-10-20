using System;

namespace AreaPerimeterCalculator
{
    class Rectangle
    {
        private double _side1;
        private double _side2;
        public Rectangle()
        {
            Console.WriteLine("Please Type First Side");
            _side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Type Second Side");
            _side2 = Convert.ToDouble(Console.ReadLine());
        }
        public double Areacalculator()
        {
            double areaCalculator = _side1 * _side2;
            return areaCalculator;
        }
        public double Perimetercalculator()
        {
            double perimetercalculator = 2 * (_side1 + _side2);
            return perimetercalculator;
        }
        public double GetArea()
        {
            return Areacalculator();
        }
        public double GetPerimeter()
        {
            return Perimetercalculator();
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle instance = new Rectangle();
            Console.WriteLine($"The Area is `{instance.Areacalculator()}");
            Console.WriteLine($"The Perimeter is `{instance.Perimetercalculator()}");

        }
    }
    
}
