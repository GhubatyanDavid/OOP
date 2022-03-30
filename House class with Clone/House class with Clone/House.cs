using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_class_with_Clone
{
    internal class House
    {
        private string houseAdress;
        private int houseNumber;
        public string HouseAdress
        {
            set { houseAdress = value; }
            get { return houseAdress; }
        }
        public int HouseNumber
        {
            set { houseNumber = value; }
            get {  return houseNumber; }
        }
        public override string ToString()
        {
            return $"House Adress`{houseAdress} , House Number`{houseNumber}";
        }
        
    }
}
