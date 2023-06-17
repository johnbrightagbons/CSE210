using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int reply = 0;
            string textQuestion = string.Empty;
            string file = string.Empty;
            Entry entry = new Entry();
            Journal journal = new Journal();

            entry.ShowMenu();

            while (reply != 5)
            {
                entry.menu();
                reply = int.Parse(Console.ReadLine());

                if (reply == 1)
                {
                    Prompt prompt = new Prompt();
                    textQuestion = prompt.DisplayRandomQuestion();
                    Console.WriteLine(textQuestion);
                    string answer = Console.ReadLine();
                    string date = entry.DateToString();
                    entry.entries.Add($"Date: {date} - prompt: {textQuestion} \n {answer}");
                }
                else if (reply == 2)
                {
                    if (File.Exists(journal.FileName))
                    {
                        journal.DisplayJournal();
                    }
                }
                else if (reply == 3)
                {
                    Console.WriteLine("What is your file name? ");
                    file = Console.ReadLine();
                    journal.FileName = file;
                }
                else if (reply == 4)
                {
                    if (File.Exists(journal.FileName))
                    {
                        foreach (string i in entry.entries)
                        {
                            journal.WriteFile(i);
                        }
                    }
                }
                else if (reply == 5)
                {
                    Console.WriteLine("Exiting the program...");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}
