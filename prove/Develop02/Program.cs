using System;

namespace JournalApplication
{

class Program
    {
        static void Main(string[] args)
        {
            int _reply = 0;
            string _textQuestion = string.Empty;
            string _file = string.Empty;
            Entry _entry = new Entry();
            Journal myJournal = new Journal();
            _entry.ShowMenu();

            while (_reply !=5)
            {
                _entry.menu();
                _reply = int.Parse(Console.ReadLine());
            }

            if (_reply == 1)
            {
                Prompt _prompt = new Prompt(); 
                _textQuestion = __prompt.DisplayRandomQuestion();
                Console.WriteLine(_textQuestion);
                string _answer = Console.ReadLine();
                string date = _entry.DateToString ();
                _entry._enteries.Add ($"Date: {date}  - prompt: {_textQuestion} \n {_Answwer}");    
            }

            else if (_reply == 2)
            {
                if (File.Exists(_jounral._fileName));
                {
                    _journal.DisplayJournal();
                }
            

            else
                {
                    foreach (string i in _entry._enteries);
                }
                    {
                        Console.WriteLine($"{i}");
                    }
            

            else if (_reply == 3)
            {
                Console.WriteLine("What is your file name? ");
                _file = Console.ReadLine();
                _journal._fileName = _fileName;
            }

            else if (_reply == 4)
            {
                if (File.Exists(_journal._fileName))
                {
                    foreach (string i in _entry._enteries)
                    {
                        _journal.WriteFile(i);
                    }
                }
            }

            else 
            {
                Console.WriteLine("What is your file name? ");
                _file = Console.ReadLine();
                _journal._fileName = _fileName;
                _Journal.CreateFile();
                foreach (string i in _entry._enteries)
                {
                    _journal.WriteFile(i);
                }
            }    
    }   }      
}
