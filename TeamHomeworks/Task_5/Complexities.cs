using System;
namespace TeamHomeworks.Task_5
{
    public enum Complexities
    {
        Hard,
        Medium,
        Easy
    }

    public class Complexity
    {
        public static Complexities SetComplexity()
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
                            return Complexities.Hard;
                        case 2:
                            return Complexities.Medium;
                        case 3:
                            return Complexities.Easy;
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
