using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace JournalApplication
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        private string _fileName = string.Empty;

        public Journal(string fileName)
        {
            _fileName = fileName;
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayTheEntries()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        // Load the file
        public void RunTheFile()
        {
            Title = "Journal Application";
            ShowMenu();
            // TODO : rest of logic
            DisplayOutro();
        }

        // Create the journal file
        private void CreateJournal()
        {
            using (FileStream fs = File.Create(_fileName)) { }
        }

        // Show a menu of options so that the user can choose
        private void ShowMenu()
        {
            // Set the journal color
            ForegroundColor = ConsoleColor.DarkBlue;
            BackgroundColor = ConsoleColor.DarkRed;
            Clear();

            // Display the welcome message of the journal and
            // the various options available to the user
            WriteLine("Welcome to the journal Program");
            WriteLine("Kindly select an option from the following list");
            WriteLine("1. Write");
            WriteLine("2. Display");
            WriteLine("3. Load");
            WriteLine("4. Save");
            WriteLine("5. Quit");
            WriteLine("What would you like to do? ");
            string option = ReadLine();

            // Process the selected option
            switch (option)
            {
                case "1":
                    WriteToJournal();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    LoadJournal();
                    break;
                case "4":
                    SaveJournal();
                    break;
                case "5":
                    // Quit the application
                    break;
                default:
                    WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        // Display journal contents
        public void DisplayJournal()
        {
            using (StreamReader sr = File.OpenText(_fileName))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    WriteLine(line);
                }
            }
        }

        // Write to the journal file
        public void WriteToJournal()
        {
            WriteLine("Enter the text to write to the journal:");
            string line = ReadLine();

            using (StreamWriter outputFile = File.AppendText(_fileName))
            {
                outputFile.WriteLine(line);
            }
        }

        // Load the journal file
        public void LoadJournal()
        {
            if (File.Exists(_fileName))
            {
                _entries.Clear();

                using (StreamReader sr = File.OpenText(_fileName))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        _entries.Add(new Entry(line));
                    }
                }

                WriteLine("Journal loaded successfully.");
            }
            else
            {
                WriteLine("Journal file does not exist.");
            }
        }

        // Save the journal file
        public void SaveJournal()
        {
            using (StreamWriter sw = File.CreateText(_fileName))
            {
                foreach (Entry entry in _entries)
                {
                    sw.WriteLine(entry.Text);
                }
            }

            WriteLine("Journal saved successfully.");
        }

        // Closing message
        private void DisplayOutro()
        {
            WriteLine("Thanks for using the Journal Application.");
            ReadKey(true);
        }
    }

    public class Entry
    {
        public string Text { get; set; }

        public Entry(string)
    }
