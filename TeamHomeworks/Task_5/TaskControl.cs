using System;
namespace TeamHomeworks.Task_5
{
    public class TaskControl
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
                                Helpers.CreateTaskList();
                                break;
                            case 2:
                               Helpers.GetTasksList();
                                break;
                            case 3:
                                Helpers.GetTime();
                                break;
                            case 4:
                                Helpers.GetTasksbyPriority();
                                break;
                            case 5:
                                Helpers.TasksInDays();
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
