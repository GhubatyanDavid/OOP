using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        
        public override void SaveDocument()
        { Console.WriteLine("Document saved in new format"); }
    }
}
