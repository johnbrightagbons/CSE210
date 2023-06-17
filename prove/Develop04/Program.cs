class Program
{
    static void Main(string[] args)
    {
        MindfulnessGame mind = new MindfulnessGame();

        for (int time = 5; time > 0; time--)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while (DateTime.Now < endTime)
        {
            Console.Write("...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Done!");
    }
}
