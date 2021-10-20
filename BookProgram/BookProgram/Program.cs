using System;

namespace BookProgram
{
    class Book
    {
        private string _book;
        public string show()
        {
            Console.WriteLine("Please Type Book name`");
            _book = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            return _book;
        }
    }
    class Title
    {
        private string _title;
        public string show()
        {
            Console.ResetColor();
            Console.WriteLine("Please Type Book Title`");
            _title = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            return _title;
        }

    }
    class Author
    {
        private string _author;
        public string show()
        {
            Console.ResetColor();
            Console.WriteLine("Please Type Book Author`");
            _author = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            return _author;
        }
    }
    class Content
    {
        private string _content;
        public string show()
        {
            Console.ResetColor();
            Console.WriteLine("Please Type Book Content`");
            _content = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            return _content;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book instance = new Book();
            Title instance1 = new Title();
            Author instance2 = new Author();
            Content instance3 = new Content();
            Console.WriteLine(instance.show());
            Console.WriteLine(instance1.show());
            Console.WriteLine(instance2.show());
            Console.WriteLine(instance3.show());
        }
    }
}
