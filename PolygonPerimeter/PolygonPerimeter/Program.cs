using System;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5,6,"Point1");
            Point point1 = new Point(6, 6,"Point2");
            Point point2 = new Point(6, 9, "Point3");
            Point point3 = new Point(9, 5, "Point4");
            Figure figure = new Figure(point,point1,point2,point3);
        }
        
    }
}
