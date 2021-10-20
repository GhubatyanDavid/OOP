using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Opening the Document");
        }
        public override void Create()
        {
            Console.WriteLine("Creating the TXT Document");
        }
        public override void Change()
        {
            Console.WriteLine("Changing the TXT Document");
        }
        public override void Save()
        {
            Console.WriteLine("Saving the TXT Document");
        }
    }
}
