using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        { Console.WriteLine("Document Open"); }
        public virtual void EditDocument()
        { Console.WriteLine("Change Document can be in Pro Version"); }
        public virtual void SaveDocument()
        {Console.WriteLine("Save Document can be in Pro Version"); }

    }
}
