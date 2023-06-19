public class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _word = "";
        for (int i = 0; i < _word.Length; i++)
        {
            _word += "_";
        }
    }

    public string ShowWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _word == "";
    }
}
