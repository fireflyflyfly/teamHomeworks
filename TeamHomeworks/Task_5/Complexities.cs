using System;
namespace TeamHomeworks.Task_5
{
    public class Complexity
    {
        public static Complexities SetComplexity()
        {
            int attempts = 3;
            while (attempts != 0)
            {
                Console.WriteLine("\nPlease chose your rask complexity (1 - hard, 2 - medium, 3 - easy): ");

                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    switch (number)
                    {
                        case 1:
                            return Complexities.Hard;
                        case 2:
                            return Complexities.Medium;
                        case 3:
                            return Complexities.Easy;
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
                Console.WriteLine("\nYou are out of attempts, task complexity was automatically set to Easy.");
            }
            return Complexities.Easy;
        }
    }
}
