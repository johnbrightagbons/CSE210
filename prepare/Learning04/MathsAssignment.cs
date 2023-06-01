public class MathsAssignment : Assignment
{
    private string _textbookChapter;
    private string _questions;


    public MathsAssignment(string name, string topic, string textbookChapter, string _questions): base(name, topic)
    {
        _textbookChapter = textbookChapter;
        _questions = questions;
    }

    public string GetHomework()
    {
        return $"Chapter {_textbookChapter} Questions {_questions}";
    }
}