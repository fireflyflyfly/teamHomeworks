using System;
using TasksExtenstion;
using ProgramExtentions5_2;
namespace ProgramExtentions5_1
{
    public class Task_5
    {

        public static void Task5Selector() 
        {
            while (true)
            {
                Console.WriteLine("\nEnter 1 to add a new task." +
                    "\nEnter 2 to see the list of existing tasks." +
                    "\nEnter 3 to calculate the time required for all your tasks." +
                    "\nEnter 4 to get the list of tasks by priority." +
                    "\nEnter 5 to see how many tasks you can do in selected amount of days.");

                int userSelection;

                if (int.TryParse(Console.ReadLine(), out userSelection))
                {
                    switch (userSelection)
                    {
                        case 1:
                            Task_5_Custom_Methods.CreateTaskList();
                            break;
                        case 2:
                            Task_5_Custom_Methods.GetTasksList();
                            break;
                        case 3: Task_5_Custom_Methods.GetTime();
                            break;
                        case 4:
                            Task_5_Custom_Methods.GetTasksbyPriority();
                            break; 
                        default:
                            Console.WriteLine("\nSelected option does not exist, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOnly digits are allowed, please try again.");

                }
            }
        }
    }
}
