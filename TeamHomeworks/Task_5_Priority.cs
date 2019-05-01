using System;
namespace PriorityStuff
{
        public enum Priority
        {
            Low,
            Medium,
            High
        }

    public class Task_5_Priority
    {

        public static Priority SetPriority() 
        {
            while (true)
            {
                Console.WriteLine("\nPlease enter your task priority (1 - high, 2- medium, 3 - low): ");

                int number;
                if (int.TryParse(Console.ReadLine(), out (number)))
                {
                    switch (number)
                    {
                        case 1:
                            return Priority.High;
                        case 2:
                            return Priority.Medium;
                        case 3:
                            return Priority.Low;
                        default:
                            Console.WriteLine("\nPriority you entered does not exist, try again");
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
