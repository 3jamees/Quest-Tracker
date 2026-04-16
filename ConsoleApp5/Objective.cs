namespace QuestProgressTracker
{
    public class Objective
    {
        public string Name { get; set; }
        public int RequiredAmount { get; set; }
        public int CurrentAmount { get; set; }
       
        public Objective(string name, int requiredAmount)
        {   
            Name = name;
            RequiredAmount = requiredAmount;
            CurrentAmount = 0;
        }
    }
}