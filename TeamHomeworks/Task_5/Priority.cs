using System;
namespace TeamHomeworks.Task_5
{
    public class Priority
    {
        public static Priorities SetPriority()
        {
            int attempts = 3;
            while (attempts != 0)
            {
                Console.WriteLine("\nPlease enter your task priority (1 - high, 2- medium, 3 - low): ");

                int number;
                if (int.TryParse(Console.ReadLine(), out (number)))
                {
                    switch (number)
                    {
                        case 1:
                            return Priorities.High;
                        case 2:
                            return Priorities.Medium;
                        case 3:
                            return Priorities.Low;
                        default:
                            Console.WriteLine("\nPriority you entered does not exist, try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOnly digits are allowed, please try again.");
                    attempts--;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("\nYou are out of attempts, task priority was automatically set to Low.");
            }
            return Priorities.Low;
        }
    }
}
