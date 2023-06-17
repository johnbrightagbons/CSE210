public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string content, Reference reference)
    {
        List<string> stringList = content.Split(" ").ToList();
        foreach (string word in stringList)
        {
            Word anotherWord = new Word(word);
            _words.Add(anotherWord);
        }
        _reference = reference;
    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void HideWords()
    {
        Random random = new Random();
        var randomDex = random.Next(0, _words.Count);
        while (_words[randomDex].IsHidden())
        {
            randomDex = random.Next(0, _words.Count);
            _words[randomDex].HideWord();
        }
    }

    public string GetRenderedText()
    {
        string reply = "";
        for (int j = 0; j < _words.Count; j++)
        {
            reply += _words[j].ShowWord() + " ";
        }
        return reply;
    }

    public bool IsCompletelyHidden()
    {
        int count = 0;
        for (int j = 0; j < _words.Count; j++)
        {
            if (_words[j].ShowWord().Substring(0, 1) == "-")
            {
                count++;
            }
        }
        if (count == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
