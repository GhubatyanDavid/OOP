using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_in_Shop
{
    class Article
    {
        private string _cheese;
        public string Cheese
        {
            get{return _cheese;}
            set{_cheese = value;}
        }
        private string _meat;
        public string Meat
        {
            get { return _meat; }
            set { _meat = value; }
        }
        private string _vegetables;
        public string Vegetables
        {
            get { return _vegetables; }
            set { _vegetables = value; }
        }
        private string _superShop;
        public string SuperShop
        {
            get { return _superShop; }
            set { _superShop = value; }
        }
        private int _cheesePrice;
        public int CheesePrice
        {
            get { return _cheesePrice; }
            set { _cheesePrice = value; }
        }
        private int _meatPrice;
        public int MeatPrice
        {
            get { return _meatPrice; }
            set { _meatPrice = value; }
        }
        private int _vegetablesPrice;
        public int VegetablesPrice
        {
            get { return _vegetablesPrice; }
            set { _vegetablesPrice = value; }
        }

    }
}
