using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class CarCollection<T>
    {
        private Car[] _car;

        public Car[] Car
        {
            set { _car = value; }
            get { return _car; }
        }
        public CarCollection(Car car, Car car1, Car car2, Car car3, Car car4)
        {
            _car = new Car[5];
            _car[0] = car;
            _car[1] = car1;
            _car[2] = car2;
            _car[3] = car3;
            _car[4] = car4;
        }
    }
}
