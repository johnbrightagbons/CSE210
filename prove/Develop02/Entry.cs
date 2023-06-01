
public class Entry {
        public string _question= "";
        public string _answer= "";
        public string _dateText = "";
      
        public void Display()
    {
        Console.WriteLine($"Date: {_dateText} - Prompt: {_question} \n{_answer} \n");
    }
      }


   