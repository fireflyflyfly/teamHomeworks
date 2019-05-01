using System;
using System.Collections.Generic;
using TasksExtenstion;
using PriorityStuff;
using ComplexityStuff;
using System.Linq;
namespace ProgramExtentions5_2
{
    public class Task_5_Custom_Methods
    {

       public static List <Tasks> TaskList = new List<Tasks>();

        public static void CreateTaskList()
        {
                Console.WriteLine("\nPlease enter the name of your task: ");
                string taskName = Console.ReadLine();
                Priority priority = Task_5_Priority.SetPriority();
                Complexity complexity = Task_5_Complexity.SetComplexity();

                TaskList.Add(new Tasks
                {
                    TaskName = taskName,
                    TaskPriority = priority,
                    TaskDifficulty = complexity
                });
        }

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

        public static void GetTime() 
        { 
            int timeAmount= 0;
            for (int i = 0; i < TaskList.Count; i++) 
            {

                if (TaskList[i].TaskDifficulty == Complexity.Hard) 
                {
                    timeAmount = timeAmount + 4;  
                }
                else if (TaskList[i].TaskDifficulty == Complexity.Medium) 
                {
                    timeAmount = timeAmount + 2; 
                }
                else if (TaskList[i].TaskDifficulty == Complexity.Easy) 
                {
                    timeAmount = timeAmount + 1; 
                }
                }
            Console.WriteLine("\nThe amount of time you need for your tasks is: " + timeAmount);
            }

        public static void GetTasksbyPriority() 
        {
            Console.WriteLine("\nPlease enter the priority to sort tasks by (1 - high, 2 - medium, 3 - low):");

            int number; 
                if (int.TryParse(Console.ReadLine(), out number))
                switch (number)
                {
                    case 1:
                        for (int i = 0; i < TaskList.Count; i++)
                        {
                                if (TaskList[i].TaskPriority == Priority.High)
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
                                if (TaskList[i].TaskPriority == Priority.Medium)
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
                                if (TaskList[i].TaskPriority == Priority.Low)
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
         
         public static void TasksInDays() 
         {
            TaskList.Sort((a, b) => -a.TaskPriority.CompareTo(b.TaskPriority));

            for (int i = 0; i < TaskList.Count; i++)
            {
                if (TaskList[i].TaskDifficulty == Complexity.Hard)
                { TaskList[i].time = 4; }
                else if (TaskList[i].TaskDifficulty == Complexity.Medium)
                { TaskList[i].time = 2; }
                else if (TaskList[i].TaskDifficulty == Complexity.Easy)
                { TaskList[i].time = 1; }
            }

            Console.WriteLine("\nPlease enter desired amount of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int requiredTime = 0; 
            Console.WriteLine("\nHere is the list of task you can do in " + days + " day(s).");
            for (int i = 0; i < TaskList.Count; i++)
            {
                if (requiredTime < days * 8) 
                {
                    requiredTime = requiredTime + TaskList[i].time;

                    Console.WriteLine(TaskList[i].TaskName);
                    Console.WriteLine(Convert.ToString(TaskList[i].TaskPriority));
                    Console.WriteLine(Convert.ToString(TaskList[i].TaskDifficulty));
                    Console.WriteLine(Convert.ToString(TaskList[i].time));
                    Console.WriteLine("\n");
                }

            }
         }

        }
        }


