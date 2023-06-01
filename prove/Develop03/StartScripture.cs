using System;

public class StartScripture;

{
    public List <Scripture> _scriptureTitle = new List <Scripture> ();
    Selection random = new Selection ();
    public void LoadToFile()

    {
        string filename = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] half = line.split ("-");
            string[] reference_string = half[0].split(",");
                if (reference_string.length == 3)
                {
                    Reference _reference = new Reference (reference_string[0], reference_string[1], reference_string[2]);
                    string _items = half[1];
                    Scripture _scripture = new Scripture (_items, _reference);
                    _scriptureTitle.Add(_scripture);
                }
                else
                {
                    Reference _reference = new Reference (reference_string[0], reference_string[1], reference_string[2]);
                    string _items = half[1];
                    Scripture _scripture = new Scripture (_items, _reference);
                    _scriptureTitle.Add(_scripture); 
                }
        }
    }

    public Scripture getScripture()
    {
        var selectionIndex = selection.Next(0, _scriptureTitle.Count);
        return _scriptureTitle[selectionIndex];
    }
}