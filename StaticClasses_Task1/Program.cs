using System;
using System.Collections.Generic;

namespace StaticClasses_Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book.Notes.AddNote("note 1");
            Book.Notes.AddNote("note 2");
            Book.Notes.AddNote("note 3");
            Book.Notes.AddNote("note 4");
            Book.Notes.PrintAllNotes();
            Console.ReadKey();
        }
    }

    internal static class Book
    {
        public static class Notes
        {
            private static int index = 0;
            private static string[] notes = new string[100];

            public static void AddNote(string note)
            {
                notes[index] = note;
                index++;
            }

            public static void PrintAllNotes()
            {
                foreach (string n in notes)
                {
                    if(n!=null) Console.WriteLine(n);
                }
            }
        }
    }
}
