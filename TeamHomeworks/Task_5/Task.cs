using System;
namespace TeamHomeworks.Task_5
{
    public class Task
    {
        public string TaskName;
        public Priorities TaskPriority;
        public Complexities TaskDifficulty;
        public int Time
        {
            get
            {
                if (TaskDifficulty == Complexities.Hard)
                    return 4;
                else if (TaskDifficulty == Complexities.Medium)
                    return 2;
                else if (TaskDifficulty == Complexities.Easy)
                    return 1;
                else return 0; 
            }
        }
    }
}
