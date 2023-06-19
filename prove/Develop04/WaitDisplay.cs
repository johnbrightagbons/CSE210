class WaitDisplay
{
    private int _waitingTime;
    private const int AnimationDelay = 200; // Delay between animation frames in milliseconds

    public WaitDisplay(int waitingTime)
    {
        _waitingTime = waitingTime;
    }

    public void DisplayAndWait(string message)
    {
        Console.Write(message);
        AnimateWaiting();
        Console.WriteLine();
    }

    private void AnimateWaiting()
    {
        Console.CursorVisible = false;

        string[] animationFrames = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddMilliseconds(_waitingTime);
        while (DateTime.Now < endTime)
        {
            foreach (string frame in animationFrames)
            {
                Console.Write(frame);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Thread.Sleep(AnimationDelay);
            }
        }

        Console.CursorVisible = true;
    }
}
