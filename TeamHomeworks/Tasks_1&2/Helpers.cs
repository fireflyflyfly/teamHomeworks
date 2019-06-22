using System;
namespace TeamHomeworks.Task_1_2
{
    public class Helpers
    {

        // gets a validated double from console input. 
        public static double GetFigureDimensions()
        {
            int i = 3;
            double x = 0;
            while (i > 0)
            {
                if (double.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\nOnly gigits are allowed. Please try again. You have {(i - 1)} attempts left.");
                    i--;
                }
            }

            if (i == 0)
            {
                x = Randomizer.SetRandomValue();
                Console.WriteLine("\nYou are out of attempts. The value has been automatically set to :" + x);
            }
            return x;
        }

        //
        public static void FitSquareIntoCircle(Square square, Circle circle)
        {
            if (square.SquareSide / Math.Sqrt(2) <= circle.CircleRadius)
            {
                Console.WriteLine("\nYour square fits inside your circle!");
            }

            else
            {
                Console.WriteLine("\nYour square does not fit inside your circle.");
            }

        }

        public static void FitCirleIntoSquare(Circle circle, Square square)
        {
            if (square.SquareSide >= circle.CircleRadius * 2)
            {
                Console.WriteLine("\nYour circle fits inside your square!");
            }

            else
            {
                Console.WriteLine("\nYour circle does not fit inside your square.");
            }
        }
    }
}
