using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("You can Play the Music");
        }

        public void Record()
        {
            Console.WriteLine("Recording The Music");
        }

    }
}
