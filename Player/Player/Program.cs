using System;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            playable.Play();
            playable.Pause();
            playable.Stop();
            IRecordable recordable = new Player();
            recordable.Record();
            recordable.Pause();
            recordable.Stop();
        }
    }
}
