using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Bicycle
    {
            private string _bycicleName;
            private string _bycicleYear;
            public Bicycle(string bicycleName, string bicycleYear)
            {
                _bycicleName = bicycleName;
                _bycicleYear = bicycleYear;
            }
            public override string ToString()
            {
            return "Car: " + _bycicleName + " " + _bycicleYear ;
            }
        }
}
