namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        private int value;
        private string goalDescription;

        public SimpleGoal(string name, string goalDescription, int value) : base(name)
        {
            this.value = value;
        }

        public SimpleGoal(string name, string goalDescription) : base(name)
        {
            this.goalDescription = goalDescription;
        }

        public override void RecordEvent()
        {
            IsCompleted = true;
        }

        public override int GetValue()
        {
            return value;
        }
    }
}
