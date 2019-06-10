using System;
using TeamHomeworks.Task1;
using TeamHomeworks.Task_3;
namespace TaskSelector
{
    public class TaskRunner
    {
        public static void TaskLauncher()
        {
            Console.WriteLine("Please enter the number of homework task you want to launch: ");
            string taskNumber = Console.ReadLine();
            int x;
            if (int.TryParse(taskNumber, out x))
            {
                if (Convert.ToInt32(taskNumber) == 1 || Convert.ToInt32(taskNumber) == 2)
                {
                    FigureComparision.CreatAndCompareFigures();
                }
                else if (Convert.ToInt32(taskNumber) == 3)
                {
                    Task3Runner.RunTask3();  
                }
                else if (Convert.ToInt32(taskNumber) == 4)
                {
                    ProgramExtensions4.Task_4.Reverser();
                }
                else if (Convert.ToInt32(taskNumber) == 5)
                { 
                ProgramExtentions5_1.Task_5.Task5Selector(); 
                }
                }
                else 
                {
                    Console.WriteLine("Task you are looking for does not exist or the number is incorrect.");
                }
            }
        }
    }

