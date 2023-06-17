public class StartScripture
{
    private List<Scripture> _scriptureTitle = new List<Scripture>();
    private Random random = new Random();

    public void LoadToFile()
    {
        string filename = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] half = line.Split("-");
            string[] referenceString = half[0].Split(",");
            string items = half[1].Trim();
            Reference reference;

            if (referenceString.Length == 3)
            {
                reference = new Reference(referenceString[0], int.Parse(referenceString[1]), int.Parse(referenceString[2]));
            }
            else
            {
                reference = new Reference(referenceString[0], int.Parse(referenceString[1]), int.Parse(referenceString[2]), int.Parse(referenceString[3]));
            }

            Scripture scripture = new Scripture(items, reference);
            _scriptureTitle.Add(scripture);
        }
    }

    public Scripture GetScripture()
    {
        int selectionIndex = random.Next(0, _scriptureTitle.Count);
        return _scriptureTitle[selectionIndex];
    }
}
