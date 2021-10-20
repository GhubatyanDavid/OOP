using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    class Array
    {
        private int[] _array = new int[6]; 
        public int this[int index]
        {
            set
            {
                _array[index] = value;
            }
            get
            {
                return _array[index];
            }
            
        }
        public void MinMax()
        {
            int max = _array[0];
            for (int index = 0; index < _array.Length; index++)
            {
                if (_array[index] > max)
                    max = _array[index];
            }
            Console.WriteLine($"The Maximum Element is`{max}");
            int min = _array[0];
            for (int index = 0; index <_array.Length; index++)
            {
                if (_array[index] < min)
                    min = _array[index];
            }
            Console.WriteLine($"The Minimum element is` {min}");
        }
        public void Sum()
        {
            int sum = 0;
            for (int index = 0; index < _array.Length; index++)
            {
                sum += _array[index];
            }
            Console.WriteLine($"Array Sum`{sum}");
        }
        public void ArithmeticElements()
        {
            int AritEL = 0;
            for (int index = 0; index < _array.Length; index++)
            {
                AritEL += _array[index];
            }
            Console.WriteLine($"Arithmetic mean of all elements is`{AritEL/2}");
        }
        public void OddValue()
        {
            for (int index = 0; index < _array.Length; index++)
            {
                if(_array[index]%2!=0)
                    Console.WriteLine($"All ODD Values`{_array[index]}");
            }
        }
    }
}
