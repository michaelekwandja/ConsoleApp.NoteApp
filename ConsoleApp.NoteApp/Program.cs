using ConsoleApp.NoteApp;
using System;
using System.Collections.Generic;


while (true)
{
    Console.WriteLine("Note App Menu:");
    Console.WriteLine("1. Add a Note");
    Console.WriteLine("2. View Notes");
    Console.WriteLine("3. Delete Note");
    Console.WriteLine("4. Exit");

    int choice = MenuResults.GetUserChoice();
    switch (choice)
    {
        case 1:
            MenuResults.AddNote();
            break;
        case 2:
            MenuResults.ViewNotes();
            break;
        case 3:
            Console.Write("Enter the index of the note to delete: ");
            int index = int.Parse(Console.ReadLine());
            MenuResults.DeleteNote(index);
            break;
        case 4:
            Console.WriteLine("Exiting Note App. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}



    
    

    
