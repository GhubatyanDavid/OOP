using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFormat
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Opening The Document");
        }
        public override void Create()
        {
            Console.WriteLine("Creating the DOC Document");
        }
        public override void Change()
        {
            Console.WriteLine("Changing the DOC Document");
        }
        public override void Save()
        {
            Console.WriteLine("Saving the DOC Document");
        }
    }
}
