using System;
namespace TeamHomeworks.Task_6
{
    public class BulbHelper
    {
        public static ColouredBulb SetBulbColour()
        {
            int attempts = 3;
            while (attempts != 0)
            {
                Console.WriteLine("Please choose the color of your bulb. Colors allowed: Red = 1, Yellow = 2, Green = 3, Blue = 4");
                if (int.TryParse(Console.ReadLine(), out int number) && number <= 4 && number >= 1)
                {
                    Colour colour = (Colour)number;
                    ColouredBulb colouredBulb = new ColouredBulb(colour);
                    return colouredBulb;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please use only digits form 1 to 4");
                    attempts--;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("You are out of attempts, color has been set to Red. ");
            }
            ColouredBulb defaultColouredBulb = new ColouredBulb(Colour.Red);
            return defaultColouredBulb;
        }
    }
}
