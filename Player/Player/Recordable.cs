using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    interface IRecordable
    {
        void Record();
        void Pause()
        {
            Console.WriteLine("Pause the Music");
        }
        void Stop()
        {
            Console.WriteLine("Stoping The Music");
        }

    }
}
