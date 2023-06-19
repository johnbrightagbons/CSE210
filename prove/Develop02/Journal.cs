using System;
using System.Collections.Generic;
using System.IO;

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

        public void WriteToJournal()
        {
            Console.WriteLine("Enter the text to write to the journal:");
            string line = Console.ReadLine();

            _entries.Add(new Entry(line));
            Console.WriteLine("Entry added successfully.");
        }

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

                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("Journal file does not exist.");
            }
        }

        public void SaveJournal()
        {
            using (StreamWriter sw = File.CreateText(_fileName))
            {
                foreach (Entry entry in _entries)
                {
                    sw.WriteLine(entry.Text);
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
    }
}
