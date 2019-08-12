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
            Priority priority = PriorityHelper.SetPriority();
            Complexity complexity = ComplexityHelper.SetComplexity();

            TaskList.Add(new Task
            {
                TaskName = taskName,
                Priority = priority,
                Complexity = complexity
            });
        }

        // Shows a list of all existing tasks. 
        public static void GetTasksList()
        {
            TaskList.ForEach(task =>
            {
                PrintTaskInfo(task);
            });
        }

        // Shows the amount of time required to complete all existing tasks. 
        public static void GetTime()
        {
            int timeAmount = 0;
            TaskList.ForEach(task =>
            {
                timeAmount += Convert.ToInt32(task.Complexity);
            });
            Console.WriteLine("\nThe amount of time you need for your tasks is: " + timeAmount + " hours.");
        }

        // Shows a list of tasks grouped by priority and sorted by complexity.
        public static void GetTasksbyPriority()
        {
            Console.WriteLine("\nPlease enter the priority to filter tasks by (1 - high, 2 - medium, 3 - low):");
            var isParsed = int.TryParse(Console.ReadLine(), out int number1);
            Priority priority = (Priority)number1;

            var list = new List<Task>();
            list = TaskList.Where(t => t.Priority.Equals(priority)).ToList();
            list.Sort((x, y) => -x.Complexity.CompareTo(y.Complexity));
            list.ForEach(Task =>
            {
                PrintTaskInfo(Task);
            });
        }


        // Shows how many tasks can be done in X amount of days based on priorities of existing tasks.
        public static void TasksInDays()
        {
            var sortedList = new List<Task>();
            sortedList = TaskList.OrderBy(p => p.Priority).ThenByDescending(p => p.Complexity).ToList();

            Console.WriteLine("\nPlease enter desired amount of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int requiredTime = 0;
            Console.WriteLine("\nHere is the list of tasks you can do in " + days + " day(s).");
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (requiredTime + Convert.ToInt32(sortedList[i].Complexity) <= days * 8)
                {
                    requiredTime += Convert.ToInt32(sortedList[i].Complexity);

                    PrintTaskInfo(sortedList[i]);
                }
            }
        }


        // A method to print all info about a task. 
        private static void PrintTaskInfo(Task task)
        {
            var e = task.Priority.ToString();
            var t = (int)task.Complexity;
            Console.WriteLine(task.TaskName);
            Console.WriteLine(Convert.ToString(task.Priority));
            Console.WriteLine(Convert.ToString(task.Complexity));
            Console.WriteLine(Convert.ToInt32(task.Complexity));
            Console.WriteLine("\n");

            Console.WriteLine("\n" + System.Environment.NewLine);

        }

        public static void FillWithTasks()
        {
            TaskList.Add(new Task
            {
                TaskName = "task 1",
                Priority = Priority.High,
                Complexity = Complexity.Easy,
            });

            TaskList.Add(new Task
            {
                TaskName = "task 2",
                Priority = Priority.High,
                Complexity = Complexity.Medium,
            });

            TaskList.Add(new Task
            {
                TaskName = "task 3",
                Priority = Priority.High,
                Complexity = Complexity.Medium,
            });

            TaskList.Add(new Task
            {
                TaskName = "task 4",
                Priority = Priority.Medium,
                Complexity = Complexity.Hard
            });

            TaskList.Add(new Task
            {
                TaskName = "task 5",
                Priority = Priority.Low,
                Complexity = Complexity.Medium,
            });
        }
    }
}

