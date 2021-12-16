using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Car
    {
        private string _carName;
        private string _carYear;
        public Car(string CarName, string CarYear)
        {
            _carName = CarName;
            _carYear = CarYear;
        }
        public override string ToString()
        {
            return "Car: " + _carName + " " + _carYear;
        }
    }
}
