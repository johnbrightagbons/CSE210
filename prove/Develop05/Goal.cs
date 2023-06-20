namespace EternalQuest
{
    abstract class Goal
    {
        public string Name { get; }
        public bool IsCompleted { get; protected set; }
        public string Description { get; internal set; }

        public Goal(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public abstract void RecordEvent();
        public abstract int GetValue();
    }
}
