using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    interface IPlayable
    {
        void Play();
        void Pause()
        {
            Console.WriteLine("You can Pause The Music");
        }
        void Stop()
        {
            Console.WriteLine("You can Stop The Music");
        }
    }
}
