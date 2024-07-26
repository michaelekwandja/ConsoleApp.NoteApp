using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.NoteApp
{
    public class MenuResults
    {
        public static List<string> notes = new List<string>();

        public static int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }
        public static void AddNote()
        {
            Console.Write("Enter your note: ");
            string note = Console.ReadLine();
            notes.Add(note);
            Console.WriteLine("Note added successfully!");
        }
        public static void ViewNotes()
        {
            Console.WriteLine("Your Notes:");
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        public static void DeleteNote(int index)
        {
            if (index >= 0 && index < notes.Count)
            {
                notes.RemoveAt(index);
                Console.WriteLine("Note deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index. Note not found.");
            }
        }

    }
}
