using System;

namespace JournalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal("journal.txt");
            int reply = 0;

            while (reply != 5)
            {
                Entry.ShowMenu();
                reply = int.Parse(Console.ReadLine());

                switch (reply)
                {
                    case 1:
                        journal.WriteToJournal();
                        break;
                    case 2:
                        journal.DisplayTheEntries();
                        break;
                    case 3:
                        journal.LoadJournal();
                        break;
                    case 4:
                        journal.SaveJournal();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program...Have a nice day");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
