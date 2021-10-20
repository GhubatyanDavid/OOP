using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonPerimeter
{
    class Point
    {
        private int _pointA;
        private int _pointB;
        private string _name;
        public int PointA 
        { 

            get
            {
                return _pointA;
            }
        }
        public int PointB { get => _pointB;}
        public string Name { get=> _name; }

        public Point(int pointA,int pointB,string name)
        {
            _pointA = pointA;
            _pointB = pointB;
            _name = name;
        }
    }
}
