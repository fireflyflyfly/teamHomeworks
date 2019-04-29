using System;
using System.Linq;
using ProgramExtentions;
using ProgramExtentions2;
namespace TaskSelector
{
    public class TaskRunner
    {
        public static void TaskLauncher()
        {
            Console.WriteLine("Please enter the number of homework task you want to launch: ");
            string taskNumber = Console.ReadLine();
            int x; 
            if (int.TryParse (taskNumber, out x)) 
            {
                if (Convert.ToInt32 (taskNumber) == 1 || Convert.ToInt32(taskNumber) == 2) 
                {
                    ProgramExtentions.Extentions.CalculateSquareArea();
                    ProgramExtentions.Extentions.CircleArea();
                    ProgramExtentions.Extentions.CircleInYourSquare();
                    ProgramExtentions.Extentions.SquareInYourCircle();
                }
                else if (Convert.ToInt32(taskNumber) == 3) 
                {
                    ProgramExtentions2.Task3.RangeCreation();
                }
                else 
                {
                    Console.WriteLine("Task you are looking for does not exist or the number is incorrect.");
                }
            }
        }
    }
}
