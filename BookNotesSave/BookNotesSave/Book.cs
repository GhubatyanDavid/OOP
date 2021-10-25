using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNotesSave
{
    class Book
    {
        public string UserNotes(string notes)
        {
            Notes notes1 = new Notes();
            return notes1.UserNotes(notes);
        }
        class Notes
        {
            public string UserNotes(string notes)
            {
                Console.WriteLine("Your Note Saved!");
                Console.WriteLine("If you want see type 1 if not type 2");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                string userNotes = notes;
                if(userNumber == 1)
                    Console.WriteLine(notes);
                else
                    Console.WriteLine("Bye!!");
                return userNotes;
            }
        }
    }
}
