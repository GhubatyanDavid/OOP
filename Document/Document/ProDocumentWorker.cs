using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        { Console.WriteLine("Document Changed."); }
        public override void SaveDocument()
        { Console.WriteLine("Document Saved in the old format, saving in other formats is available in the Expert version."); }
    }
}
