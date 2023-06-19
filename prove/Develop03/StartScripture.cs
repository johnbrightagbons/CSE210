public class StartScripture
{
    public List<Scripture> ScriptureTitle { get; private set; }

    public StartScripture()
    {
        LoadScriptures();
    }

    private void LoadScriptures()
    {
        ScriptureTitle = new List<Scripture>();

        string scriptureText = "charity is the pure love of Christ, and it endureth forever; and whosoe is found possessed of it";
        Reference reference = new Reference("Moroni", 7, 47);
        Scripture scripture = new Scripture(scriptureText, reference);
        ScriptureTitle.Add(scripture);
    }
}