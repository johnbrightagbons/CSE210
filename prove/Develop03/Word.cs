using System;

public class Word;

// Attributes for the word class
{
    private string _word;
    public word(string word)
    {
       _word = word; 
    }

    public void hideWord()
    {
        string newWord = " ";
        foreach (char c in _word)
        {
            newWord += "_";
        }
    }

    public string showWord()
    {
        return _word;
    }

    public Boolean isHidden()
    {
        if (_word.sSubstring (1,2) == "_")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
