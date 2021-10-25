using System;

namespace BookNotesSave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type anything you want in your note :)");
            string userType = Console.ReadLine();
            Book book = new Book();
            book.UserNotes(userType);
        }
    }
}
