using System;

namespace DocumentFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLHandler xml = new XMLHandler();
            TXTHandler txt = new TXTHandler();
            DOCHandler doc = new DOCHandler();
            while (true)
            {
                Console.WriteLine("Please Type Format of Document -- Example` XML , DOC , TXT or (Click X for exit)");
                string format = Console.ReadLine();
                if (format == "XML")
                {
                    xml.Open();
                    Console.WriteLine(new string('-', 50));
                    xml.Create();
                    Console.WriteLine(new string('-', 50));
                    xml.Change();
                    Console.WriteLine(new string('-', 50));
                    xml.Save();
                }
                else if (format == "DOC")
                {
                    doc.Open();
                    Console.WriteLine(new string('-', 50));
                    doc.Create();
                    Console.WriteLine(new string('-', 50));
                    doc.Change();
                    Console.WriteLine(new string('-', 50));
                    doc.Save();
                }
                else if (format == "TXT")
                {
                    txt.Open();
                    Console.WriteLine(new string('-', 50));
                    txt.Create();
                    Console.WriteLine(new string('-', 50));
                    txt.Change();
                    Console.WriteLine(new string('-', 50));
                    txt.Save();
                }
                else
                {
                    Console.WriteLine("Wrong FORMAT!!! Please Try Again");
                }
            }
        }
    }
}
