using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal interface IVehicleCollection<T>
    {
        public void  AddCar(T car, int number);
        public T this[int index]
            { get;}
        public int Count
        {
            get;
        }
    }
}
