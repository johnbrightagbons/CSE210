using System;

class Program
{
    static void Main(string[] args)
    {
        StartScripture scriptureList = new StartScripture();
        scriptureList.LoadToFile();
        string dataType = " ";
        Scripture scripture = scriptureList.GetScripture();
        Reference reference = scripture.GetReference();
        while (dataType != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{reference.GetReference()} {scripture.GetRenderedText()}\n");
            Console.WriteLine("Kindly press enter from the keyboard to continue or kindly type 'quit' to end. ");
            dataType = Console.ReadLine();
            Console.Clear();
            scripture.HideWords();

            if (scripture.IsCompletelyHidden())
            {
                dataType = "quit";
            }            
        }
    }
}
