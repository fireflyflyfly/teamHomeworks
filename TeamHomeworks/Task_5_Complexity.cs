using System;
namespace ComplexityStuff
{
    public enum Complexity 
    { 
        Hard, 
        Medium, 
        Easy
    }

    public class Task_5_Complexity
    {
        public static Complexity SetComplexity()
        {
            while (true) 
            {
                Console.WriteLine("\nPlease chose your rask complexity (1 - hard, 2 - medium, 3 - easy): ");

                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    switch (number)
                    {
                        case 1:
                            return Complexity.Hard;
                        case 2:
                            return Complexity.Medium;
                        case 3:
                            return Complexity.Easy;
                        default:
                            Console.WriteLine("\nComplexity you entered does not exist, try again.");
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

