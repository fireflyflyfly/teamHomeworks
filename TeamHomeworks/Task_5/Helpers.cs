using System;
using System.Collections.Generic;
namespace TeamHomeworks.Task_5
{
    public class Helpers
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
            for (int i = 0; i < TaskList.Count; i++)
            {
                Console.WriteLine(TaskList[i].TaskName);
                Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                Console.WriteLine("\n");
            }
        }

        // Shows the amount of time required to complete all existing tasks. 
        public static void GetTime()
        {
            int timeAmount = 0;
            for (int i = 0; i < TaskList.Count; i++)
            {

                if (TaskList[i].TaskDifficulty == Complexities.Hard)
                {
                    timeAmount = timeAmount + 4;
                }
                else if (TaskList[i].TaskDifficulty == Complexities.Medium)
                {
                    timeAmount = timeAmount + 2;
                }
                else if (TaskList[i].TaskDifficulty == Complexities.Easy)
                {
                    timeAmount = timeAmount + 1;
                }
            }
            Console.WriteLine("\nThe amount of time you need for your tasks is: " + timeAmount + " hours.");
        }

        // Shows a list of tasks grouped by priority. 
        public static void GetTasksbyPriority()
        {
            Console.WriteLine("\nPlease enter the priority to filter tasks by (1 - high, 2 - medium, 3 - low):");

            int number;
            if (int.TryParse(Console.ReadLine(), out number))
                switch (number)
                {
                    case 1:
                        for (int i = 0; i < TaskList.Count; i++)
                        {
                            if (TaskList[i].TaskPriority == Priorities.High)
                            {
                                Console.WriteLine(TaskList[i].TaskName);
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                                Console.WriteLine("\n");
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < TaskList.Count; i++)
                        {
                            if (TaskList[i].TaskPriority == Priorities.Medium)
                            {
                                Console.WriteLine(TaskList[i].TaskName);
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                                Console.WriteLine("\n");
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < TaskList.Count; i++)
                        {
                            if (TaskList[i].TaskPriority == Priorities.Low)
                            {
                                Console.WriteLine(TaskList[i].TaskName);
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                                Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                                Console.WriteLine("\n");
                            }
                        }
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
            Console.WriteLine("\nHere is the list of task you can do in " + days + " day(s).");
            for (int i = 0; i < TaskList.Count; i++)
            {
                if (requiredTime < days * 8)
                {
                    requiredTime = requiredTime + TaskList[i].Time;

                    Console.WriteLine(TaskList[i].TaskName);
                    Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                    Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                    Console.WriteLine(Convert.ToString(TaskList[i].Time));
                    Console.WriteLine("\n");
                }

            }
        }

    }
}
