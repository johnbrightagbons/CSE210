using System;

public class Reference;

// Attributes of the reference class
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference (string book, int _chapter, int _verse);
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int _chapter, int _verse);
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string getReference()
    {
        string reference;
        if (_endVerse == " ")
        {
            reference = $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
        return reference
    }
}