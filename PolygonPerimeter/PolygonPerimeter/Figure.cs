using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonPerimeter
{
    class Figure
    {
        private Point[] _points;
        public Point[] Points
        {
            set
            { _points = value; }
            get
            { return _points; }
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            _points = new Point[4];
            _points[0] = a;
            _points[1] = b;
            _points[2] = c;
            _points[3] = d;  
        }
        public double LenghtSide(Point a, Point b)
        {
            Console.WriteLine("Point Name`");
            Console.WriteLine(a.Name);
            Console.WriteLine("Sum of two Side`");
            int c = a.PointA + b.PointA;
            Console.WriteLine(c);
            return c;
        }
        public void Perimetercalculator()
        {
            int perimeter = 0;
            for (int i = 0; i < _points.Length; i++)
            {
                perimeter += _points[i].PointA;
            }
            Console.WriteLine($"Perimeter of Figure`{perimeter}");
        }
    }
}
