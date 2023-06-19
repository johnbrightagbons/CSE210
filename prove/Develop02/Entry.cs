using System;

namespace JournalApplication
{
    public class Entry
    {
        public string Text { get; set; }

        public Entry(string text)
        {
            Text = text;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to the Journal Application");
            Console.WriteLine("Please select an option from the following list:");
            Console.WriteLine("1. Write to journal");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
        }

        public void Display()
        {
            Console.WriteLine(Text);
        }
    }
}
