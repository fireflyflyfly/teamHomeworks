using System;
namespace TeamHomeworks.Task_5
{
    public class Task
    {
        public string TaskName { get; set; }
        public Priorities TaskPriority { get; set; }
        public Complexities TaskDifficulty { get; set; }
        public int Time
        {
            get
            {
                if (this.TaskDifficulty == Complexities.Hard)
                    return 4;
                else if (this.TaskDifficulty == Complexities.Medium)
                    return 2;
                else if (this.TaskDifficulty == Complexities.Easy)
                    return 1;
                else return 0; 
            }
        }
    }
}
