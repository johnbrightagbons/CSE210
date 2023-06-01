using System;

class Program
{
    static void Main(string[] args)
    {
        scripturePassage scriptureList = new scripturePassage();
        scriptureList.LoadToFile();
        string dataType = " ";
        Scripture scripture = scriptureList.getScripture();
        Reference reference = scripture.getReference();
        while (dataType != "quit")

        {
            Console.clear();
            Console.WriteLine ($"{reference.getReference()} {scripture.getRenderedText()}\n ");
            Console.WriteLine ("Kindly press enter from the keyboard to continue or kindly type 'quit' to end. ")
            dataType = Console.ReadLine();
            Console.clear();
            scripture.hideWord();

            if (scripture.IsCompleteHiden())
            {
                dataType = "quit";
            }            
        }

    }
}