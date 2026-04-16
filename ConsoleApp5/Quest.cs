namespace QuestProgressTracker
{
    public class Quest
    {
        private List<Objective> objectives = new List<Objectives>();

        public Quest(string name)
        {
            
        }

        public bool IsCompleted
        {
            get
            {
                foreach (var obj in objectives)
                {
                    if (obj.CurrentAmount < obj.RequiredAmount)
                        return false;
                }
                return objectives.Count > 0;
            }
        }

        public void AddObjective(string name, int requiredAmount)
        {
             objectives.Add(new Objective(name, requiredAmount));
        }

        public Objective GetObjective(string name)
        {
           foreach (var obj in objectives)
            {
                if (obj.Name == name)
                    return obj;
            }

            throw new Exception();
        }

        public void ProgressObjective(string name, int amount)
        {
            if (amount < 0)
                throw new Exception();

            var obj = GetObjective(name);
            obj.CurrentAmount += amount;
        }
    }
}
