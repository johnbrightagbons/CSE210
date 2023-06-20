namespace EternalQuest
{
    class EternalGoal : Goal
    {
        private int value;

        public EternalGoal(string name, string goalDescription, int value) : base(name)
        {
            this.value = value;
        }

        public override void RecordEvent()
        {
            // No need to mark as completed for eternal goals
        }

        public override int GetValue()
        {
            return value;
        }
    }
}
