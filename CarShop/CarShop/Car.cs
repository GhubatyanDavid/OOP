using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Car
    {
        private string _name;
        private string _surName;
        private string _carName;
        private string _carYear;
        public Car(string carName, string carYear,string name,string surName)
        {
            _name = name;
            _surName = surName;
            _carName = carName;
            _carYear = carYear;
        }
        public string Name
        { 
            get
            { 
                return _name;
            }
        }
        public override string ToString()
        {
            return "Car: " + _carName + " " + _carYear + " Name` " + _name + " Surname` " + _surName;
        }
        
    }
}
