using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHomeworks.Task_5
{
    public class TaskOperations
    {
        public static List<Task> TaskList = new List<Task>();

        // Adds a single task to Task list. 
        public static void CreateTaskList()
        {
            Console.WriteLine("\nPlease enter the name of your task: ");
            string taskName = Console.ReadLine();
            Priorities priority = Priority.SetPriority();
            Complexities complexity = Complexity.SetComplexity();

            TaskList.Add(new Task
            {
                TaskName = taskName,
                TaskPriority = priority,
                TaskDifficulty = complexity
            });
        }

        // Shows a list of all existing tasks. 
        public static void GetTasksList()
        {
            TaskList.ForEach(task =>
            {
                Console.WriteLine(task.TaskName);
                Console.WriteLine(Convert.ToString(task.TaskPriority));
                Console.WriteLine(Convert.ToString(task.TaskDifficulty));
                Console.WriteLine("\n");
            });
        }

        // Shows the amount of time required to complete all existing tasks. 
        public static void GetTime()
        {
            int timeAmount = 0;
            TaskList.ForEach(task =>
            {
                timeAmount += Convert.ToInt32(task.TaskDifficulty);
            });
            Console.WriteLine("\nThe amount of time you need for your tasks is: " + timeAmount + " hours.");
        }

        // Shows a list of tasks grouped by priority. SORT THIS STUFF BY COMPLEXITY, use linq.
        public static void GetTasksbyPriority()
        {
            Console.WriteLine("\nPlease enter the priority to filter tasks by (1 - high, 2 - medium, 3 - low):");

            int number;
            if (int.TryParse(Console.ReadLine(), out number))
                switch (number)
                {
                    case 1:
                        List<Task> HighPrioTasks = TaskList.Where(t => t.TaskPriority.Equals(Priorities.High)).ToList();
                        HighPrioTasks.Sort((x, y) => -x.TaskDifficulty.CompareTo(y.TaskDifficulty));

                        HighPrioTasks.ForEach(task =>
                        {
                            PrintTaskInfo(task);
                        });
                        break;

                    case 2:
                        List<Task> MediumPrioTasks = TaskList.Where(t => t.TaskPriority.Equals(Priorities.Medium)).ToList();
                        MediumPrioTasks.Sort((x, y) => -x.TaskDifficulty.CompareTo(y.TaskDifficulty));

                        MediumPrioTasks.ForEach(task =>
                        {
                            PrintTaskInfo(task);
                        });
                        break;

                    case 3:
                        List<Task> LowPrioTasks = TaskList.Where(t => t.TaskPriority.Equals(Priorities.High)).ToList();
                        LowPrioTasks.Sort((x, y) => -x.TaskDifficulty.CompareTo(y.TaskDifficulty));

                        LowPrioTasks.ForEach(task =>
                        {
                            PrintTaskInfo(task);
                        });
                        break;

                    default:
                        Console.WriteLine("\n Only options 1, 2 and 3 are allowed. Please try again.");
                        break;
                }
            else { Console.WriteLine("\n Only options 1, 2 and 3 are allowed. Please try again."); }
        }


        // Shows how many tasks can be done in X amount of days based on priorities of existing tasks.
        public static void TasksInDays()
        {
            TaskList.Sort((a, b) => -a.TaskPriority.CompareTo(b.TaskPriority));

            Console.WriteLine("\nPlease enter desired amount of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int requiredTime = 0;
            Console.WriteLine("\nHere is the list of tasks you can do in " + days + " day(s).");
            for (int i = 0; i < TaskList.Count; i++)
            {
                if (requiredTime + Convert.ToInt32(TaskList[i].TaskDifficulty) <= days * 8)
                {
                    requiredTime += Convert.ToInt32(TaskList[i].TaskDifficulty);

                    PrintTaskInfo(TaskList[i]);
                }
            }
        }

        private static void PrintTaskInfo(Task task)
        {
            Console.WriteLine(task.TaskName);
            Console.WriteLine(Convert.ToString(task.TaskPriority));
            Console.WriteLine(Convert.ToString(task.TaskDifficulty));
            Console.WriteLine(Convert.ToInt32(task.TaskDifficulty));
            Console.WriteLine("\n");
        }
    }
}
