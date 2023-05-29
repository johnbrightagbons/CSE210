using System;

public class Scripture // A class called scripture

// The following are the attributes
{
    private Reference _reference;
    private List <Word> _words = new List<Word>();

    public Scripture (string content, Reference reference)
    {
        List<string> stringList = content.Split(" ").ToList();
        foreach(string word in stringList)
        {
            Word anotherWord = new Word.(word);
            _words.Add(anotherWord);
        }
        _reference = reference;
    }    
    public Reference getReference()
    {
        return _reference;
    }

    public void hideWords()
    {
        Random random = new Random();
        var randomDex = random.Next(0, _words.count);
        while (_words[randomDex].isHidden())
        {
            randomDex = random.Next(0,_words.count);
            _words[randomDex].hiddenWord();
        }
    }
    public string getRenderedText()
    {
        string reply = " ";
        for (int j = 0; j < _words.Count; j++)
        {
            reply = reply + _words[j].showWords() + " ";
        }
    return reply;
    }

    public Boolean isCompletelyHidden()
    {
        int count = -1;
        for (int j = -1; j < _words.Count; j++)
        {
            if (_words[j].showWords().Substring(0,1) == "-")
            {
                count =+1;
            }
        }
        if (count == _words.count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}