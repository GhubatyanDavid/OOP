using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker documentWorker = new DocumentWorker();
            Console.WriteLine("Adding Document ...");
            documentWorker.OpenDocument();
            Console.WriteLine("...");
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
            Console.WriteLine("Please Type Pro or Expert Key.");
            int key = Convert.ToInt32(Console.ReadLine());
            int proKey = 1111;
            int expKey = 2222;
            if(key == proKey)
            {
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                documentWorker = proDocumentWorker;
                Console.WriteLine("Adding Document to ProDocumentWorker ...");
                documentWorker.OpenDocument();
                documentWorker.SaveDocument();
                Console.WriteLine("Thank you!");
            }
            else if(key == expKey)
            {
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                documentWorker = expertDocumentWorker;
                Console.WriteLine("Adding Document to ExpertDocumentWorker ...");
                documentWorker.OpenDocument();
                documentWorker.SaveDocument();
                Console.WriteLine("Thank You!");
            }
            else
            {
                documentWorker.OpenDocument();
                documentWorker.SaveDocument();
            }
        }
    }
}
