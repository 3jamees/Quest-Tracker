namespace QuestProgressTracker
{
    public class Objective
    {
        public string Name { get; set; }
        public int RequiredAmount { get; set; }

        private int currentAmount;
        public int CurrentAmount
        {
            get { return currentAmount; }
            set
            {
                if (value > RequiredAmount)
                    currentAmount = RequiredAmount;
                else
                    currentAmount = value;
            }
        }

        public Objective(string name, int requiredAmount)
        {
            Name = name;
            RequiredAmount = requiredAmount;
            CurrentAmount = 0;
        }
    }
}