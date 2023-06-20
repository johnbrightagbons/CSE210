namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int targetTimes;
        private int perEventValue;
        private int bonusValue;
        private int timesCompleted;

        public int TargetTimes { get { return targetTimes; } }
        public int TimesCompleted { get { return timesCompleted; } }

        public ChecklistGoal(string name, string goalDescription, int targetTimes, int perEventValue, int bonusValue) : base(name)
        {
            this.targetTimes = targetTimes;
            this.perEventValue = perEventValue;
            this.bonusValue = bonusValue;
            timesCompleted = 0;
        }

        public override void RecordEvent()
        {
            timesCompleted++;
            if (timesCompleted >= targetTimes)
                IsCompleted = true;
        }

        public override int GetValue()
        {
            if (timesCompleted < targetTimes)
                return perEventValue;
            else
                return perEventValue + bonusValue;
        }
    }
}
