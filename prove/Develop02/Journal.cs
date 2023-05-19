using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JournalApplication
{

    class Journal
    {    
        public string _fileName = string.Empty;
        public Journal() { }

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
            using (FileStream fs = File.Create(_fileName)) {}
         }

        // Show a menu of option so that the user can choose
        static string ShowMenu() 
        {
            // Set the journal colour
            ForegroundColor = ConsoleColor.DarkBlue;
            BackgroundColor = ConsoleColor.DarkRed;
            Clear();

            // Display the welcome message of the journal and
            // the various options available to the user
            Console.WriteLine("Welcome to the journal Program");
            Console.WriteLine("Kindly select an option from the following list");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            string option = Console.ReadLine();
            return option;
        }
        

        // Display journal contents
        public void DisplayJournal() 
        {
            using (StreamReader _sr = File.OpenText(_fileName))
            {
                string _short = "";
                while ((_short = _sr.ReadLine()) ! = null)
                {
                    Console.WriteLine(_short);
                }
            }
         }
        
    
        public string  WriteToJournal (string _line)
        {
            using (StreamWriter outputFile = File.AppendText(_fileName))     
            {
                outputFile.WriteLine(_line);
            }
        }

        // Closing message
        private void DisplayOutro() 
        {
            WriteLine ("Thanks for using the Journal Application. ");
            ReadKey(true);
        }
        


    }
}





