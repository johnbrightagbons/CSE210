using System;

class Program
{
    static void Main(string[] args)
    {
        StartScripture scriptureList = new StartScripture();

        // Get the first scripture from the list
        if (scriptureList.ScriptureTitle.Count > 0)
        {
            Scripture scripture = scriptureList.ScriptureTitle[0];
            Reference reference = scripture.GetReference();

            string dataType = " ";
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
        else
        {
            Console.WriteLine("No scriptures loaded.");
        }
    }
}